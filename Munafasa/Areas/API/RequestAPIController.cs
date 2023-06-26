using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Munafasa.Data.IRepositories;
using Munafasa.Models.ApiModels;
using Munafasa.Models.Tables;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.API
{
    [ApiController]
    [Route(Routes.RequestRoute)]
    [ApiExplorerSettings(GroupName = "Request")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RequestAPIController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RequestAPIController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult GetClientRquests()
        {
            var userId = int.Parse(User.FindFirst("userId")?.Value!);
            var requests = _unitOfWork.Request.GetAll(x=> x.ClientId == userId).Select(RequestDto.FromRequest);
            return Ok(new ResponseModel(success: true, data: requests));
        }

        [HttpGet]
        public IActionResult GetClientStatusRequests()
        {
            var userId = int.Parse(User.FindFirst("userId")?.Value!);
            var allReqs = _unitOfWork.Request.GetAll(x => x.ClientId == userId).Select(RequestDto.FromRequest);
            var newReqs = allReqs.Where(x=> x.Status == (int)StatusEnumeration.New);
            var inProgressReqs = allReqs.Where(x => x.Status >= (int)StatusEnumeration.PendingAdminApproval && x.Status >= (int)StatusEnumeration.Done);
            var doneReqs = allReqs.Where(x => x.Status == (int)StatusEnumeration.Done);
            var canceledReqs = allReqs.Where(x => x.Status == (int)StatusEnumeration.Canceled);


            return Ok(new ResponseModel(success: true, data: new
            {
                newReqs,
                inProgressReqs,
                doneReqs,
                canceledReqs
            }));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] AddRequestModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var userId = int.Parse(User.FindFirst("userId")?.Value!) ;
                var client = _unitOfWork.Client.GetFirstOrDefault(x => x.Id == userId);
                var request = requestModel.toRequestModel(client!);
                _unitOfWork.Request.Add(request);
                _unitOfWork.Save();
                if (requestModel.images != null)
                {
                    foreach (var file in requestModel.images)
                    {
                        string imagePath = await new FileHelper(_hostEnvironment)
                            .SaveFile(path: "Images/Requests/", file: file);
                        var image = new RequestImage()
                        {
                            RequestId = request.Id,
                            Url = imagePath,
                        };
                        _unitOfWork.RequestImages.Add(image);
                    }
                }
                _unitOfWork.Save();
                return Ok(new ResponseModel(success: true));
            }
            return BadRequest(new ResponseModel(success: false, errors: ModelState));
        }
    }
}

