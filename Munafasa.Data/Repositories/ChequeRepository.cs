using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ChequeRepository : Repository<Cheque> , IChequeRepository
	{
        private readonly ApplicationDbContext _db;

        public ChequeRepository(ApplicationDbContext db):base(db) 
        {
            _db = db;
        }

        void IChequeRepository.Update(Cheque cheque)
        {
            _db.Cheques.Update(cheque);
        }
    }
}

