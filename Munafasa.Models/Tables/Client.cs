using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Munafasa.Models.Tables
{
	public class Client
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Addresss { get; set; }
        [Required]
        public string Password { get; set; }
        public string? ProfileImage { get; set; }
        [Required]
        public string Building { get; set; }
        public string? Apartment { get; set; }
        [Required]
        public string Floor { get; set; }
        [Required]
        public int ContractId { get; set; }
        [ForeignKey("ContractId")]
        public Contract Contract { get; set; }
        public List<Request> Requests { get; set; }
    }
}

