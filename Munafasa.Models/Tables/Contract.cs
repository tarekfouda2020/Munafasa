using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Munafasa.Utilities;

namespace Munafasa.Models.Tables
{
	public class Contract
	{
        [Key]
		public int Id { get; set; }
        [ValidateNever]
        [DisplayName("Contract Number")]
        public string ContractNumber { get; set; }
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
        [Required]
        public string Address { get; set; }
        [Required]
        [DisplayName("Max Spare Price")]
        public double MaxSparePrice { get; set; }
        [Required]
        [DisplayName("Contract Price")]
        public double ContractPrice { get; set; }
        [Required]
        [DisplayName("Start Date")]
        public DateTime FromDate { get; set; }
        [Required]
        [DisplayName("End Date")]
        public DateTime ToDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ValidateNever]
        public int Status { get; set; } = (int)AdminStatusEnumeration.active;
        [Required]
        [DisplayName("Owner")]
        public int OwnerId { get; set; }
        [ValidateNever]
        public bool Deleted { get; set; } = false;
        [ForeignKey("OwnerId")]
        [ValidateNever]
        public Owner Owner { get; set; }
        [ValidateNever]
        public List<ContractAttacments> Attacments { get; set; }
        [ValidateNever]
        public List<Client> Clients { get; set; }
        [ValidateNever]
        public List<ContractService> ContractServices { get; set; }
        [ValidateNever]
        public List<Cheque> Cheques { get; set; }
        [ValidateNever]
        public List<Request> Requests { get; set; }
    }
}

