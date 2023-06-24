using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ContractAttachmentsRepository : Repository<ContractAttacments>, IContractAttachmentsRepository
    {
        private readonly ApplicationDbContext _db;
		public ContractAttachmentsRepository(ApplicationDbContext db): base(db)
		{
            _db = db;
		}

        void IContractAttachmentsRepository.Update(ContractAttacments attacment)
        {
            _db.ContractAttacments.Update(attacment);
        }
    }
}

