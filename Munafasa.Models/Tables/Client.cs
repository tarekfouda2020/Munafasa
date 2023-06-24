using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Munafasa.Models.Tables
{
	public class Client
	{
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("User Name")]
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
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        [DisplayName("Contract")]
        public int ContractId { get; set; }
        [ForeignKey("ContractId")]
        [ValidateNever]
        public Contract Contract { get; set; }
        [ValidateNever]
        public List<Request> Requests { get; set; }
    }
}

