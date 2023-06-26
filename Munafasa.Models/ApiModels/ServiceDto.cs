using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ApiModels
{
	public class ServiceDto
	{

        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public LocalizedValue Des { get; set; }
        public LocalizedValue Name { get; set; }


        public static ServiceDto FromService(Service service)
        {
            return new ServiceDto()
            {
                Des = new LocalizedValue(service.DesAr, service.DesEn) ,
                Name = new LocalizedValue(service.NameAr, service.NameEn),
                Id = service.Id,
                ImageUrl = service.ImageUrl,
            };
        }

    }

}

