using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class Client
	{
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Client Name")]
        public string UserName { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Addresss { get; set; }
        [Required]
        public double Lat { get; set; }
        [Required]
        public double Lng { get; set; }
        [Required]
        public string Password { get; set; }
        public string? ProfileImage { get; set; }
        [Required]
        public string Building { get; set; }
        public string? Apartment { get; set; }
        [Required]
        public string Floor { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ValidateNever]
        public int Status { get; set; } = (int)AdminStatusEnumeration.active;
        [ValidateNever]
        public bool Deleted { get; set; } = false;
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

