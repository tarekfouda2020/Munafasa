using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Munafasa.Models.Tables
{
	public class RequestImage
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Url { get; set; }
		[Required]
		public int RequestId { get; set; }
		public bool IsAfter { get; set; } = false;
		[ForeignKey("RequestId")]
		public Request Request { get; set; }
	}
}

