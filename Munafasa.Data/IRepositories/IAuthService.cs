using System;
using System.IdentityModel.Tokens.Jwt;
using Munafasa.Models.ApiModels;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IAuthService
	{

		public JwtSecurityToken CreateJWTToekn(int id, String Phone, String UserName);

    }
}

