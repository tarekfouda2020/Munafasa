using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Munafasa.Data.Repositories
{
	public class ApplicationUserRepository : Repository<ApplicationUser> , IApplicationUserRepository
    {
		private readonly ApplicationDbContext _db;
		public ApplicationUserRepository(ApplicationDbContext db): base(db)
		{
			_db = db;
		}

        void IApplicationUserRepository.ChangeStatus(string userId)
        {
            var user = _db.Users.Find(userId);
            if (user!.Status == (int)AdminStatusEnumeration.active)
            {
                user.Status = (int)AdminStatusEnumeration.suspended;
            }
            else
            {
                user.Status = (int)AdminStatusEnumeration.active;
            }
            _db.Users.Update(user);
        }

    }
}

