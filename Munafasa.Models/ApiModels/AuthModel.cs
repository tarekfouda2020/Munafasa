using System;
namespace Munafasa.Models.ApiModels
{
	public class AuthModel
	{
		public string Phone { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? ProfileImage { get; set; }
        public string Token { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}

