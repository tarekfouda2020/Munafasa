using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class Request
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int ContractId { get; set; }
		[ForeignKey("ContractId")]
		public Contract Contract { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
        [Required]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        [Required]
        public DateTime VisitDate { get; set; }
        [Required]
        public string Desc { get; set; }
        public string? OwnerNote { get; set; }
        public string? TecnicianNote { get; set; }
        public double AdditionalPrice { get; set; }
        public int Status { get; set; } = (int) StatusEnumeration.New;
        public int Rate { get; set; }
        [Required]
        public int TechnicianId { get; set; }
        [ForeignKey("TechnicianId")]
        public Technician? Technician { get; set; }
        public List<RequestImage> RequestImages { get; set; }


    }
}

