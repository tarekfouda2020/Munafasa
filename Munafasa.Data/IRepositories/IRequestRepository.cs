using System;
using Munafasa.Models.Tables;

namespace Munafasa.Data.IRepositories
{
	public interface IRequestRepository : IRepository<Request>
	{
		public void Update(Request request);
	}
}

