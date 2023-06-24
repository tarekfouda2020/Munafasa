using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class TechServicesRepository : Repository<TechnicianService>, ITechServicesRepository
	{
		private readonly ApplicationDbContext _db;

        public TechServicesRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}

