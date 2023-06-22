using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models.ApiModels;
using Munafasa.Models.Tables;
using Munafasa.Utilities;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.API
{
    [ApiController]
    [Route(Routes.AuthRoute)]
    [ApiExplorerSettings(GroupName = "Auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(IAuthService authService, IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _authService = authService;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                if (loginModel.Type == (int)UserType.client)
                {
                    var client = _unitOfWork.Client.GetFirstOrDefault(x=> x.Phone == loginModel.Phone);
                    if (client != null)
                    {
                        var token = _authService.CreateJWTToekn(client.Id, client.Phone, client.Email);
                        AuthModel authModel = new AuthModel
                        {
                            Email = client.Email,
                            Phone = client.Phone,
                            UserName = client.UserName,
                            ProfileImage = client.ProfileImage,
                            UserId = client.Id,
                            ExpireAt = token.ValidTo,
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                        };
                        return Ok(new { success = false, data = authModel });
                    }

                }
                else if (loginModel.Type == (int)UserType.technician)
                {
                    var technician = _unitOfWork.Technicain.GetFirstOrDefault(x => x.Phone == loginModel.Phone);
                    if (technician != null)
                    {
                        var token = _authService.CreateJWTToekn(technician.Id, technician.Phone, technician.Email);
                        AuthModel authModel = new AuthModel
                        {
                            Email = technician.Email,
                            Phone = technician.Phone,
                            UserName = technician.UserName,
                            ProfileImage = technician.ProfileImage,
                            UserId = technician.Id,
                            ExpireAt = token.ValidTo,
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                        };
                        return Ok(new { success = false, data = authModel });
                    }
                }
                else
                {
                    var owner = _unitOfWork.Owner.GetFirstOrDefault(x => x.Phone == loginModel.Phone);
                    if (owner != null)
                    {
                        var token = _authService.CreateJWTToekn(owner.Id, owner.Phone, owner.Email);
                        AuthModel authModel = new AuthModel
                        {
                            Email = owner.Email,
                            Phone = owner.Phone,
                            UserName = owner.UserName,
                            ProfileImage = owner.ProfileImage,
                            UserId = owner.Id,
                            ExpireAt = token.ValidTo,
                            Token = new JwtSecurityTokenHandler().WriteToken(token),
                        };
                        return Ok(new { success = false, data = authModel });
                    }
                }

                return BadRequest(new { success = true, msg = Messages.FailedCredentials });

            }
            return BadRequest(new { success = true, errors = ModelState });

        }
    }
}

