using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Models.Tables;
using Munafasa.Utilities;

namespace Munafasa.Models.ViewModels
{
	public class RequestViewModel
	{
        [DisplayName("Request Number")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Description")]
        public string Desc { get; set; }
        public bool IsUrget { get; set; }
        [DisplayName("Notes by Owner")]
        public string? OwnerNote { get; set; }
        [DisplayName("Notes by Tecnician")]
        public string? TecnicianNote { get; set; }
        [DisplayName("Additional Price")]
        public double? AdditionalPrice { get; set; }
        [Required]
        public int Status { get; set; }
        [DisplayName("Technician")]
        public int? TechnicianId { get; set; }
        [ValidateNever]
        public List<RequestImage> RequestImages { get; set; }

        [ValidateNever]
		public IEnumerable<SelectListItem> Technicians { get; set; }
        [ValidateNever]
        public string? Errors { get; set; }


	}
}

