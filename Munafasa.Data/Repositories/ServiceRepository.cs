using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ServiceRepository : Repository<Service>, IServiceRepository
	{
        private readonly ApplicationDbContext _db;
		public ServiceRepository(ApplicationDbContext db): base(db)
		{
            _db = db;
		}

        void IServiceRepository.Update(Service service)
        {
            _db.Services.Update(service);
        }
    }
}

