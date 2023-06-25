using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class ApplicationUser : IdentityUser
    {

        [Required]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ValidateNever]
        public int Status { get; set; } = (int)AdminStatusEnumeration.active;

        [ValidateNever]
        public bool Deleted { get; set; } = false;
    }
}

