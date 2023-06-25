using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Munafasa.Models.Tables
{
	public class Cheque
	{
		[Key]
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
        [ValidateNever]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public double Price { get; set; }
		public bool Deleted { get; set; } = false;
		[Required]
		[DisplayName("Contract")]
		public int ContractId { get; set; }
        [ForeignKey("ContractId")]
		[ValidateNever]
        public Contract Contract { get; set; }
		[NotMapped]
		public string? Errors { get; set; }
	}
}

