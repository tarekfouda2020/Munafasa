using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Munafasa.Models.Tables
{
	public class ContractAttacments
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Url { get; set; }
		[Required]
		public int ContrctId { get; set; }
		[ForeignKey("ContrctId")]
		public Contract Contract { get; set; }
	}
}

