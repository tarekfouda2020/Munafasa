using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models.ApiModels;
using Munafasa.Models.Tables;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.API
{
    [ApiController]
    [Route(Routes.ContractRoute)]
    [ApiExplorerSettings(GroupName = "Contract")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ContractAPIController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public ContractAPIController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetClientContract()
        {
            var userId = int.Parse(User.FindFirst("userId")?.Value!);
            var client = _unitOfWork.Client.GetFirstOrDefault(x => x.Id == userId, x=> x.Contract);
            var contract = client!.Contract;
            return Json(new ResponseModel(success: true, data: new
            {
                contract.Id,
                contract.ContractNumber,
                name = new LocalizedValue(contract.NameAr, contract.NameEn),
                description = new LocalizedValue(contract.DesAr, contract.DesEn),
                services = contract.ContractServices.Where(s => !s.Service.Deleted).Select((s) => ServiceDto.FromService(s.Service)),
                contract.FromDate,
                contract.ToDate
            }));
        }

        [HttpGet]
        public IActionResult GetOwnerContract()
        {
            var userId = int.Parse(User.FindFirst("userId")?.Value!);
            var contracts = _unitOfWork.Contract.GetAll(x=> x.OwnerId == userId &&
            !x.Deleted && x.Status == (int)AdminStatusEnumeration.active,
            x=> x.Attacments, x => x.ContractServices,
            x => x.Cheques).Select(x=> new
            {
                x.Id,
                x.ContractNumber,
                name = new LocalizedValue(x.NameAr, x.NameEn),
                description = new LocalizedValue(x.DesAr, x.DesEn),
                x.Address,
                cheques = x.Cheques.Where(s => !s.Deleted).Select(c => new
                {
                    c.Id,
                    c.Price,
                    date = c.DateTime,
                }),
                x.ContractPrice,
                services = x.ContractServices.Where(s => !s.Service.Deleted).Select((s) => ServiceDto.FromService(s.Service)),
                attacments = x.Attacments.Select((a)=> new {
                    a.Url,
                    a.Id
                }),
                x.FromDate,
                x.ToDate
        });
            return Json(new ResponseModel(success: true, data: contracts));
        }
    }
}

