using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ViewModels
{
	public class ContractViewModel
	{
		public Contract Contract { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> Owners { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Services { get; set; }
        [DisplayName("Services")]
        public List<int> ContractServices { get; set; }
        public string? Errors { get; set; }
    }
}

