using System;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;

namespace Munafasa.Data.IRepositories
{
	public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        public void ChangeStatus(string userId);

    }
}

