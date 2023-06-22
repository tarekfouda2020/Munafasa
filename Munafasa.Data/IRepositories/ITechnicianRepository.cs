using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface ITechnicainRepository : IRepository<Technician>
	{
		public void Update(Technician technician);
	}
}

