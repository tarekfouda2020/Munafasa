using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IMoralRepository : IRepository<Moral>
	{
		public void Update(Moral moral);
	}
}

