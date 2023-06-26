using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models.ApiModels;
using Munafasa.Models.Tables;
using Munafasa.Utilities;


namespace Munafasa.Areas.API
{
    [ApiController]
    [Route(Routes.AuthRoute)]
    [ApiExplorerSettings(GroupName = "Auth")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthService _authService;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(IAuthService authService, IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _authService = authService;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _hostEnvironment = hostEnvironment;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (loginModel.Type == (int)UserType.client)
                {
                    var contract = _unitOfWork.Contract.GetFirstOrDefault(x => x.ContractNumber == loginModel.ContractNumber);
                    if (contract == null)
                    {
                        return BadRequest(new ResponseModel(success: false, msg: new LocalizedValue(Messages.FailedCredentials, Messages.FailedCredentials)));
                    }
                    var client = _unitOfWork.Client.GetFirstOrDefault(x=> x.Phone == loginModel.Phone);
               
                    if (client != null)
                    {
                        if (client.Deleted || client.Status == (int)AdminStatusEnumeration.suspended)
                        {
                            return BadRequest(new ResponseModel(success: false, msg: new LocalizedValue(Messages.blockedCredentials, Messages.blockedCredentials)));
                        }
                        var token = _authService.CreateJWTToekn(client.Id, client.Phone, client.UserName);
                        AuthModel authModel = AuthModel.FromClient(client, token);
                        return Ok(new ResponseModel(success: true, data:  new { isCreated = true, userData = authModel }));
                    }
                    else
                    {
                        return Ok(new { success = true, isCreated = false });
                    }

                }
                else if (loginModel.Type == (int)UserType.technician)
                {
                    var technician = _unitOfWork.Technicain.GetFirstOrDefault(x => x.Phone == loginModel.Phone);
                    if (technician != null)
                    {
                        if (technician.Deleted || technician.Status == (int)AdminStatusEnumeration.suspended)
                        {
                            return BadRequest(new ResponseModel(success: false, msg: new LocalizedValue(Messages.blockedCredentials, Messages.blockedCredentials)));
                        }
                        var token = _authService.CreateJWTToekn(technician.Id, technician.Phone, technician.UserName);
                        AuthModel authModel = AuthModel.FromTechnician(technician, token);
                        return Ok(new ResponseModel(success: true, data: new { isCreated = true, userData = authModel }));
                    }
                }
                else
                {
                    var owner = _unitOfWork.Owner.GetFirstOrDefault(x => x.Phone == loginModel.Phone);
                    if (owner != null)
                    {
                        if (owner.Deleted || owner.Status == (int)AdminStatusEnumeration.suspended)
                        {
                            return BadRequest(new ResponseModel(success: false, msg: new LocalizedValue(Messages.blockedCredentials, Messages.blockedCredentials)));
                        }
                        var token = _authService.CreateJWTToekn(owner.Id, owner.Phone, owner.UserName);
                        AuthModel authModel = AuthModel.FromOwner(owner, token);
                        return Ok(new ResponseModel(success: true, data: new { isCreated = true, userData = authModel }));
                    }
                }
                return BadRequest(new ResponseModel(success: false, msg: new LocalizedValue(Messages.FailedCredentials, Messages.FailedCredentials)));
            }
            return BadRequest(new ResponseModel(success: false, errors: ModelState));

        }

        //[HttpGet]
        //public IActionResult CheckAuth()
        //{
        //    var accessToken = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
        //    var userId = User.FindFirst("userId")?.Value;
        //    var claims = User.Claims.First(x => x.Type == "userId").Value;
        //    return Ok(new { success = true });
        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CompleteClientProfile(ClientDto clientDto)
        {
            if (ModelState.IsValid)
            {
                var contract = _unitOfWork.Contract.GetFirstOrDefault(x => x.ContractNumber == clientDto.ContractNumber);
                if (contract == null)
                {
                    return BadRequest(new ResponseModel(success: false, msg: new LocalizedValue(Messages.FailedCredentials, Messages.FailedCredentials)));
                }
                string? imageUrl = null;
                if (clientDto.image != null)
                {
                    string imagePath = await new FileHelper(_hostEnvironment)
                    .SaveFile(path: "Images/Clients/", file: clientDto.image);
                    imageUrl = imagePath;
                }
                Client client = clientDto.toClient(contract.Id, imageUrl);
                var token = _authService.CreateJWTToekn(client.Id, client.Phone, client.UserName);
                AuthModel authModel = AuthModel.FromClient(client, token);
                return Ok(new ResponseModel(success: true, data: authModel));
            }
            return BadRequest(new ResponseModel(success: false, errors: ModelState));
        }

    }
}

