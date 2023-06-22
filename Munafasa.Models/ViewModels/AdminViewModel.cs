using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Munafasa.Models.ViewModels
{
	public class AdminViewModel
	{
        public string? Id { get; set; }

        [Required]
		[EmailAddress]
		public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Phone]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }

        public string? Errors { get; set; }
    }
}

