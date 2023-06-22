using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ViewModels
{
	public class SettingViewModel
	{

        [ValidateNever]
        public string Phone { get; set; }
        [ValidateNever]
        public string WhatsApp { get; set; }
        [ValidateNever]
        public string Email { get; set; }
        [ValidateNever]
        public string CompanyInfoAr { get; set; }
        [ValidateNever]
        public string CompanyInfoEn { get; set; }
        [ValidateNever]
        public string AboutAr { get; set; }
        [ValidateNever]
        public string AboutEn { get; set; }
        [ValidateNever]
        public string MissionAr { get; set; }
        [ValidateNever]
        public string MissionEn { get; set; }
        [ValidateNever]
        public string VisionAr { get; set; }
        [ValidateNever]
        public string VisionEn { get; set; }

        public string? Image { get; set; }
        public string? Errors { get; set; }

        [ValidateNever]
        public List<Service> Services { get; set; }
        [ValidateNever]
        public List<Moral> Morals { get; set; }
        [Required]
        public ContactUs ContactUs { get; set; }

    }
}

