using System;
using Munafasa.Data.IRepositories;

namespace Munafasa.Data.Repositories
{
	public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ApplicationUser = new ApplicationUserRepository(db);
            Service = new ServiceRepository(db);
            Moral = new MoralRepository(db);
            Contact = new ContactRepository(db);
            Setting = new SettingRepository(db);
            Client = new ClinetRepository(db);
            Technicain = new TechnicainRepository(db);
            Owner = new OwnerRepository(db);
            Contract = new ContractRepository(db);
            ContractAttachment = new ContractAttachmentsRepository(db);
            TechServices = new TechServicesRepository(db);
            Cheque = new ChequeRepository(db);
            Request = new RequestRepository(db);
            RequestImages = new RequestImagesRepository(db);
            ContractServices = new ContractServicesRepository(db);
        }

        //Repositories

        public IApplicationUserRepository ApplicationUser { get; private set; }

        public IServiceRepository Service { get; private set; }

        public IMoralRepository Moral { get; private set; }

        public IContactRepository Contact { get; private set; }

        public ISettingRepository Setting { get; private set; }

        public IClinetRepository Client { get; private set; }

        public ITechnicainRepository Technicain { get; private set; }

        public IOwnerRepository Owner { get; private set; }

        public IContractRepository Contract { get; private set; }

        public IContractAttachmentsRepository ContractAttachment { get; private set; }

        public ITechServicesRepository TechServices { get; private set; }

        public IChequeRepository Cheque { get; private set; }

        public IRequestRepository Request { get; private set; }

        public IRequestImagesRepository RequestImages { get; private set; }

        public IContractServicesRepository ContractServices { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

