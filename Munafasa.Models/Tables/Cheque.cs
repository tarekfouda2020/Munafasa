using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Munafasa.Models.Tables
{
	public class Cheque
	{
		[Key]
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
		public double Price { get; set; }
		[Required]
		public int ContractId { get; set; }
        [ForeignKey("ContractId")]
        public Contract Contract { get; set; }
	}
}

