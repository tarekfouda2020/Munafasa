using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;

namespace Munafasa.Data.Repositories
{
	public class ClinetRepository : Repository<Client> , IClinetRepository
	{

        private readonly ApplicationDbContext _db;

        public ClinetRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void IClinetRepository.Update(Client client)
        {
            _db.Update(client);
        }
    }
}

