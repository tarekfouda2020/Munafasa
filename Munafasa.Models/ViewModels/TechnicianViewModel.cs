using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ViewModels
{
	public class TechnicianViewModel
	{
		public Technician Technician { get; set; }

		[ValidateNever]
		public List<SelectListItem> Services { get; set; }

		[DisplayName("Services")]
        public List<int> TechServices { get; set; }

        public string? Errors { get; set; }

		public IFormFile? PassportImage { get; set; }
	}
}

