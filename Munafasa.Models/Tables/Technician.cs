using System;
using System.ComponentModel.DataAnnotations;

namespace Munafasa.Models.Tables
{
	public class Technician
	{
		public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.Now;
        [Required]
        public double Salary { get; set; }
        public string? PassportImage { get; set; }
        public List<Request> Requests { get; set; }
        public List<TechnicianService> TechnicianServices { get; set; }
    }
}

