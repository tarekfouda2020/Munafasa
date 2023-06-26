using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class RequestRepository : Repository<Request>, IRequestRepository
	{
		private readonly ApplicationDbContext _db;

        public RequestRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        void IRequestRepository.Update(Request request)
        {
            _db.Requests.Update(request);
        }
    }
}

