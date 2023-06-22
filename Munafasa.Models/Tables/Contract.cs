using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Munafasa.Models.Tables
{
	public class Contract
	{
        [Key]
		public int Id { get; set; }
        public string ContractNumber { get; set; }
        [Required]
        public string DesEn { get; set; }
        [Required]
        public string DesAr { get; set; }
        [Required]
        public string NameEn { get; set; }
        [Required]
        public string NameAr { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double MaxSparePrice { get; set; }
        [Required]
        public double ContractPrice { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
        [Required]
        public string ContrctPassword { get; set; }
        [Required]
        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
        public List<ContractAttacments> Attacments { get; set; }

        public List<Client> Clients { get; set; }
        public List<ContractService> ContractServices { get; set; }
        public List<Cheque> Cheques { get; set; }
        public List<Request> Requests { get; set; }


    }
}

