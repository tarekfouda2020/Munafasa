using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Munafasa.Models.ViewModels
{
	public class LocalizedModel
	{
        [Required]
        [DisplayName("Arabic")]
        public string Ar { get; set; }
        [Required]
        [DisplayName("English")]
        public string En { get; set; }
    }
}

