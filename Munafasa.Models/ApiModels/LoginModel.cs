using System;
using System.ComponentModel.DataAnnotations;
using Munafasa.Utilities;

namespace Munafasa.Models.ApiModels
{
	public class LoginModel
	{
		[Required]
		public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Type { get; set; } = (int) UserType.client;
    }
}

