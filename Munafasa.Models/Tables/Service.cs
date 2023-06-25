using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class Service
	{
		[Key]
        public int Id { get; set; }
        [DisplayName("Image")]
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        [DisplayName("English Description")]
        public string DesEn { get; set; }
        [Required]
        [DisplayName("Arabic Description")]
        public string DesAr { get; set; }
		[Required]
        [DisplayName("English Name")]
        public string NameEn { get; set; }
        [Required]
        [DisplayName("Arabic Name")]
        public string NameAr { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ValidateNever]
        public int Status { get; set; } = (int)AdminStatusEnumeration.active;
        [ValidateNever]
        public bool Deleted { get; set; } = false;
        [NotMapped]
        public string? Errors { get; set; }
        [ValidateNever]
        public List<ContractService> ContractServices { get; set; }
        [ValidateNever]
        public List<TechnicianService> TechnicianServices { get; set; }
        [ValidateNever]
        public List<Request> Requests { get; set; }

    }
}

