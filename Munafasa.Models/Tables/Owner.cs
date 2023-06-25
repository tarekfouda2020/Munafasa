using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class Owner
	{
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Owner Name")]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [ValidateNever]
        public string? ProfileImage { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ValidateNever]
        public int Status { get; set; } = (int)AdminStatusEnumeration.active;
        [ValidateNever]
        public bool Deleted { get; set; } = false;
        [ValidateNever]
        public List<Contract> Contracts { get; set; }
        [NotMapped]
        public string? Errors { get; set; }
    }
}

