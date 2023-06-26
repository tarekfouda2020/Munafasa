using System;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using Munafasa.Models.Tables;
using Newtonsoft.Json.Linq;

namespace Munafasa.Models.ApiModels
{
	public class AuthModel
	{
		public string Phone { get; set; }
        public string? Email { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? ProfileImage { get; set; }
        public string Token { get; set; }
        public DateTime ExpireAt { get; set; }
        public string? Address { get; set; }
        public string? Building { get; set; }
        public string? Floor { get; set; }
        public string? Apartment { get; set; }

        public static AuthModel FromClient(Client client, JwtSecurityToken? jwtSecurity = null)
        {
            var model = new AuthModel
            {
                Email = client.Email,
                Phone = client.Phone,
                UserName = client.UserName,
                ProfileImage = client.ProfileImage,
                UserId = client.Id,
                Address = client.Addresss,
                Apartment = client.Apartment,
                Floor = client.Floor,
                Building = client.Building,
            };
            if (jwtSecurity != null)
            {
                model.ExpireAt = jwtSecurity.ValidTo;
                model.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurity);
            }
            return model;
        }

        public static AuthModel FromTechnician(Technician technician, JwtSecurityToken? jwtSecurity = null)
        {
            var model = new AuthModel
            {
                Email = technician.Email,
                Phone = technician.Phone,
                UserName = technician.UserName,
                ProfileImage = technician.ProfileImage,
                UserId = technician.Id,
            };
            if (jwtSecurity != null)
            {
                model.ExpireAt = jwtSecurity.ValidTo;
                model.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurity);
            }
            return model;
        }

        public static AuthModel FromOwner(Owner owner, JwtSecurityToken? jwtSecurity = null)
        {
            var model = new AuthModel
            {
                Email = owner.Email,
                Phone = owner.Phone,
                UserName = owner.UserName,
                ProfileImage = owner.ProfileImage,
                UserId = owner.Id,
            };
            if (jwtSecurity != null)
            {
                model.ExpireAt = jwtSecurity.ValidTo;
                model.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurity);
            }
            return model;
        }

    
    }
}

