using System;
using System.ComponentModel.DataAnnotations;

namespace Munafasa.Models.Tables
{
	public class Owner
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public string? ProfileImage { get; set; }
        [Required]
        public string Password { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}

