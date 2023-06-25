using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Utilities;
using Microsoft.Extensions.Options;
using Munafasa.Models.ApiModels;

namespace Munafasa.Data.Repositories
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JWT _jwt;

        public AuthService(UserManager<ApplicationUser> userManager, IOptions<JWT> jwt)
        {
            _userManager = userManager;
            _jwt = jwt.Value;
        }



        JwtSecurityToken IAuthService.CreateJWTToekn(int id, string phone, string userName)
        {

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, userName),
                new Claim("phone", phone),
            };
            //.Union(userClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.Now.AddDays(_jwt.DurationInDays),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }

        //async Task<AuthModel> IAuthService.GetUserAuthModel(ApplicationUser user)
        //{
        //    var jwtToken = await _CreateJWTToekn(user);

        //    return new AuthModel
        //    {
        //        Email = user.Email,
        //        ExpireAt = jwtToken.ValidTo,
        //        Phone = user.PhoneNumber,
        //        UserId = user.Id,
        //        UserName = user.Name,
        //        Token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
        //    };

        //}
    }
}

