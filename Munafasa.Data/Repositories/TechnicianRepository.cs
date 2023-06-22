using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class TechnicainRepository : Repository<Technician> , ITechnicainRepository
    {

        private readonly ApplicationDbContext _db;

        public TechnicainRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void ITechnicainRepository.Update(Technician technician)
        {
            _db.Update(technician);
        }
    }
}

