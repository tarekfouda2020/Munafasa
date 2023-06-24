using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Munafasa.Models.Tables
{
	public class Technician
	{
		public int Id { get; set; }
        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }

        public string? ProfileImage { get; set; }
        [Required]
        [DisplayName("Join Date")]
        public DateTime JoinDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public double Salary { get; set; }
        [DisplayName("Passport Image")]
        [ValidateNever]
        public string? PassportImage { get; set; }
        [ValidateNever]
        public List<Request> Requests { get; set; }
        [ValidateNever]
        public List<TechnicianService> TechnicianServices { get; set; }
    }
}

