using System;
using Munafasa.Models.Tables;

namespace Munafasa.Models.ApiModels
{
	public class ContractDto
	{
		public int Id { get; set; }
		public LocalizedValue Name { get; set; }
        public AuthModel Owner { get; set; }
		public double price { get; set; }
		public double MaxSparePrice { get; set; }

		public static ContractDto FromContract(Contract contract)
		{
			return new ContractDto()
			{
				Name = new LocalizedValue(contract.NameAr, contract.NameEn),
				Id = contract.Id,
				MaxSparePrice = contract.MaxSparePrice,
				price = contract.ContractPrice,
				Owner = AuthModel.FromOwner(contract.Owner),
            };

        }

    }
}

