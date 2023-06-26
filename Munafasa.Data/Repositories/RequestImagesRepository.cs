using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class RequestImagesRepository : Repository<RequestImage>, IRequestImagesRepository
    {
        private readonly ApplicationDbContext _db;
		public RequestImagesRepository(ApplicationDbContext db): base(db)
		{
            _db = db;
		}

        void IRequestImagesRepository.Update(RequestImage image)
        {
            _db.RequestImages.Update(image);
        }
    }
}

