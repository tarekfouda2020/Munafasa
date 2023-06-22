using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IClinetRepository : IRepository<Client>
	{
		public void Update(Client client);
	}
}

