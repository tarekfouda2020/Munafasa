using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ApiModels
{
	public class AddRequestModel
	{
		[Required]
		public int SeriveId { get; set; }
        [Required]
        public DateTime AvialableDateFrom { get; set; }
        [Required]
        public DateTime AvialableDateTo{ get; set; }
        [Required]
        public required string Description { get; set; }
        public List<IFormFile>? images { get; set; }
        [Required]
        public bool IsUrget { get; set; }

        public Request toRequestModel(Client client)
        {
            return new Request()
            {
                ClientId = client.Id,
                Client = client,
                ServiceId = this.SeriveId,
                Desc = Description,
                IsUrget = this.IsUrget,
                VisitDateFrom = AvialableDateFrom,
                VisitDateTo = AvialableDateTo,
            };
        }

	}
}

