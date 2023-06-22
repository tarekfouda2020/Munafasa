using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class MoralRepository : Repository<Moral>, IMoralRepository
	{
        private readonly ApplicationDbContext _db;

        public MoralRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        void IMoralRepository.Update(Moral moral)
        {
            _db.Morals.Update(moral);
        }
    }
}

