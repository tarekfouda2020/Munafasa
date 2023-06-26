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
        public string DesEn { get; set; }
        public string DesAr { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }


        public static ServiceDto FromService(Service service)
        {
            return new ServiceDto()
            {
                DesAr = service.DesAr,
                DesEn = service.DesEn,
                NameAr = service.NameAr,
                NameEn = service.NameEn,
                Id = service.Id,
                ImageUrl = service.ImageUrl,
            };
        }

    }

}

