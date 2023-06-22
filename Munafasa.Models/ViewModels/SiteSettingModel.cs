using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Munafasa.Models.ViewModels
{
	public class SiteSettingModel
	{
        [Phone]
        [Required]
        public string Phone { get; set; }
        [Required]
        [Phone]
        public string WhatsApp { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DisplayName("Arabic Information")]
        public string CompanyInfoAr { get; set; }
        [Required]
        [DisplayName("English Information")]
        public string CompanyInfoEn { get; set; }
        public string? Image { get; set; }
        public string? Errors { get; set; }
    }
}

