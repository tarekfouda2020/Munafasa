using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ContactRepository : Repository<ContactUs>, IContactRepository
	{
		private readonly ApplicationDbContext _db;

        public ContactRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
    }
}

