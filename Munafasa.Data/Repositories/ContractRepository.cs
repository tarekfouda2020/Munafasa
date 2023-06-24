using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ContractRepository : Repository<Contract> ,IContractRepository
    {
        private readonly ApplicationDbContext _db;

        public ContractRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        void IContractRepository.Update(Contract contract)
        {
            _db.Update(contract);
        }
    }
}

