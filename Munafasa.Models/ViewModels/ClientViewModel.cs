using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ViewModels
{
	public class ClientViewModel
	{
		public Client Client { get; set; }
		[ValidateNever]
		public List<SelectListItem> Contracts { get; set; }
		public string? Errors { get; set; }
	}
}

