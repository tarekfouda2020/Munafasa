using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class Request
	{
		[Key]
        [DisplayName("Request Number")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Service")]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        [ValidateNever]
        public Service Service { get; set; }
        [Required]
        [DisplayName("Client")]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        [ValidateNever]
        public Client Client { get; set; }
        [Required]
        [DisplayName("Visit date from")]
        public DateTime VisitDateFrom { get; set; }
        [Required]
        [DisplayName("Visit date to")]
        public DateTime VisitDateTo { get; set; }
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
        [ValidateNever]
        public int Status { get; set; } = (int) StatusEnumeration.New;
        [ValidateNever]
        public int Rate { get; set; }
        [ValidateNever]
        public bool Deleted { get; set; } = false;
        [DisplayName("Technician")]
        public int? TechnicianId { get; set; }
        [ForeignKey("TechnicianId")]
        [ValidateNever]
        public Technician? Technician { get; set; }
        [ValidateNever]
        public List<RequestImage> RequestImages { get; set; }

    }
}

