using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Munafasa.Models.Tables
{
	public class TechnicianService
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int ServiceId { get; set; }
		[ForeignKey("ServiceId")]
		public Service Service { get; set; }
        [Required]
        public int TechnicianId { get; set; }
        [ForeignKey("TechnicianId")]
        public Technician Technician { get; set; }
	}
}

