using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class OwnerRepository : Repository<Owner> , IOwnerRepository
    {

        private readonly ApplicationDbContext _db;

        public OwnerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void IOwnerRepository.Update(Owner owner)
        {
            _db.Update(owner);
        }
    }
}

