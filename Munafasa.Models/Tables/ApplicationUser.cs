using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class ApplicationUser : IdentityUser
    {

        [Required]
        public string Name { get; set; }

        public int Status { get; set; } = (int)AdminStatusEnumeration.active;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

