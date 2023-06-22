using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IOwnerRepository : IRepository<Owner>
	{
		public void Update(Owner owner);
	}
}

