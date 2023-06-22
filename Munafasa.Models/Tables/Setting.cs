using System;
using System.ComponentModel.DataAnnotations;

namespace Munafasa.Models.Tables
{
	public class Setting
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int Type { get; set; }
        [Required]
        public string ValueType { get; set; }
        [Required]
        public string valueAr { get; set; }
        [Required]
        public string valueEn { get; set; }

    }
}

