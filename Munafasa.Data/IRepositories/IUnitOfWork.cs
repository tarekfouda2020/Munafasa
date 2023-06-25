using System;
namespace Munafasa.Data.IRepositories
{
	public interface IUnitOfWork
	{
        public IApplicationUserRepository ApplicationUser { get; }

        public IServiceRepository Service { get; }

        public IMoralRepository Moral { get; }

        public IContactRepository Contact { get; }

        public ISettingRepository Setting { get; }

        public IClinetRepository Client { get; }

        public ITechnicainRepository Technicain { get; }

        public IOwnerRepository Owner { get; }

        public IContractRepository Contract { get; }

        public IContractAttachmentsRepository ContractAttachment { get; }

        public ITechServicesRepository TechServices { get;}

        public IChequeRepository Cheque { get;}

        void Save();
    }
}

