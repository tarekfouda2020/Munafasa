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

        public static AuthModel fromClient(Client client, JwtSecurityToken jwtSecurity)
        {
            return new AuthModel
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
                ExpireAt = jwtSecurity.ValidTo,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurity),
            };
        } 

    }
}

