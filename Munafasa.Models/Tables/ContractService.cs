using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Munafasa.Models.Tables
{
	public class ContractService
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
	}
}

