using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IChequeRepository : IRepository<Cheque>
	{
		public void Update(Cheque cheque);
	}
}

