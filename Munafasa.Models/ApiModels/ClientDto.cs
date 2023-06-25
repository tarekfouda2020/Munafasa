using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Http;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ApiModels
{
	public class ClientDto
	{
        [Required]
        public string ContractNumber { get; set; }
        [Required]
		public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Lat { get; set; }
        [Required]
        public double Lng { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Building { get; set; }
        [Required]
        public string Floor { get; set; }
		public string? Apartment { get; set; }
		public IFormFile? image { get; set; }

        public  Client toClient(int contractId, string? imageUrl)
        {
           return new Client()
            {
                Addresss = this.Address,
                Apartment = this.Apartment,
                Building = this.Building,
                ContractId = contractId,
                Floor = this.Floor,
                Password = this.Password,
                Phone = this.Phone,
                ProfileImage = imageUrl,
                Email = this.Email,
                UserName = this.Name,
                Lat = this.Lat,
                Lng = this.Lng
            };
        }

	}
}

