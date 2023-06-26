using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models.ApiModels;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.API
{
    [ApiController]
    [Route(Routes.ServiceRoute)]
    [ApiExplorerSettings(GroupName = "Service")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ServiceAPIController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceAPIController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var services = _unitOfWork.Service.GetAll(x => !x.Deleted && x.Status == (int)AdminStatusEnumeration.active)
                .Select(ServiceDto.FromService);
            return Ok(new ResponseModel(success: true, data: services));
        }
    }
}

