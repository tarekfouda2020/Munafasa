using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ContractServicesRepository : Repository<ContractService>, IContractServicesRepository
    {
		private readonly ApplicationDbContext _db;

        public ContractServicesRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}

