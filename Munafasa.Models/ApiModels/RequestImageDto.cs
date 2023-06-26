using System;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ApiModels
{
	public class RequestImageDto
	{
		public string url { get; set; }
		public int id { get; set; }

		public static RequestImageDto FromRequestImage(RequestImage image)
		{
			return new RequestImageDto()
			{
				id = image.Id,
				url = image.Url,
			};

        }
    }
}

