using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IContractAttachmentsRepository : IRepository<ContractAttacments>
	{
		public void Update(ContractAttacments attacment);
	}
}

