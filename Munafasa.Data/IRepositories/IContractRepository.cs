using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IContractRepository : IRepository<Contract>
	{
		public void Update(Contract contract);
	}
}

