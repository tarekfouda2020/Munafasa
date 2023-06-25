using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class ContactUs
    {
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        [ValidateNever]
        public bool Deleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}

