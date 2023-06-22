﻿using System;
using System.ComponentModel.DataAnnotations;

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

		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}

