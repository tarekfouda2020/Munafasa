using System;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;

namespace Munafasa.Data.IRepositories
{
	public interface ISettingRepository : IRepository<Setting>
	{
		public void UpsertCompanyImage(string imagePathAr, string imagePathEn);
        public void UpsertCompanyInfo(string infoAr, string infoEn);
        public void UpsertAboutUs(string aboutUsAr, string aboutUsEn);
        public void UpsertMission(string missionAr, string missionEn);
        public void UpsertVision(string visionAr, string visionEn);

        public void UpsertCompanyPhone(string phone);
        public void UpsertCompanyWhatsApp(string phone);
        public void UpsertCompanyEmail(string email);
        public SettingViewModel GetSettingViewModel();
        public SiteSettingModel GetSiteSettingModell();

    }
}

