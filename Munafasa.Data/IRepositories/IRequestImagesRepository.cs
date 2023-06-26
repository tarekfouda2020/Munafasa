using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IRequestImagesRepository : IRepository<RequestImage>
	{
		public void Update(RequestImage image);

    }
}

