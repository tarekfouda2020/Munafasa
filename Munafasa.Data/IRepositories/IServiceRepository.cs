using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IServiceRepository : IRepository<Service>
	{
		public void Update(Service service);
	}
}

