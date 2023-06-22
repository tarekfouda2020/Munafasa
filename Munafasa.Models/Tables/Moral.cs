using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Munafasa.Models.Tables
{
	public class Moral
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[DisplayName("Arabic Name")]
		public string NameAr { get; set; }
        [Required]
        [DisplayName("English Name")]
        public string NameEn { get; set; }
        [Required]
        [DisplayName("Arabic Description")]
        public string DesAr { get; set; }
        [Required]
        [DisplayName("English Description")]
        public string DesEn { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ValidateNever]
        public string Image { get; set; }
        [NotMapped]
        public string? Errors { get; set; }
    }
}

