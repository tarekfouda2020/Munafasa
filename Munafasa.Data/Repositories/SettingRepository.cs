using System;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;

namespace Munafasa.Data.Repositories
{
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        private readonly ApplicationDbContext _db;

        public SettingRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        SettingViewModel ISettingRepository.GetSettingViewModel()
        {
            var about = _db.Settings.SingleOrDefault(x => x.ValueType == SD.AboutUs);
            var mission = _db.Settings.SingleOrDefault(x => x.ValueType == SD.Mission);
            var vision = _db.Settings.SingleOrDefault(x => x.ValueType == SD.Vision);

            var info = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyInformation);
            var image = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyImage);
            var phone = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyPhone);
            var whatsApp = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyWhatsApp);
            var email = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyEmail);

            SettingViewModel viewModel = new SettingViewModel();
            if (about != null)
            {
                viewModel.AboutEn = about.valueEn;
                viewModel.AboutAr = about.valueAr;
            }
            if (mission != null)
            {
                viewModel.MissionEn = mission.valueEn;
                viewModel.MissionAr = mission.valueAr;
            }
            if (vision != null)
            {
                viewModel.VisionEn = vision.valueEn;
                viewModel.VisionAr = vision.valueAr;
            }
            if (info != null)
            {
                viewModel.CompanyInfoEn = info.valueEn;
                viewModel.CompanyInfoAr = info.valueAr;
            }
            if (image != null)
            {
                viewModel.Image = image.valueAr;
            }
            if (phone != null)
            {
                viewModel.Phone = phone.valueAr;
            }
            if (email != null)
            {
                viewModel.Email = email.valueAr;
            }
            if (whatsApp != null)
            {
                viewModel.WhatsApp = whatsApp.valueAr;
            }
            return viewModel;
        }

        SiteSettingModel ISettingRepository.GetSiteSettingModell()
        {
            var info = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyInformation);
            var image = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyImage);
            var phone = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyPhone);
            var whatsApp = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyWhatsApp);
            var email = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyEmail);

            SiteSettingModel viewModel = new SiteSettingModel();
           
            if (info != null)
            {
                viewModel.CompanyInfoEn = info.valueEn;
                viewModel.CompanyInfoAr = info.valueAr;
            }
            if (image != null)
            {
                viewModel.Image = image.valueAr;
            }
            if (phone != null)
            {
                viewModel.Phone = phone.valueAr;
            }
            if (email != null)
            {
                viewModel.Email = email.valueAr;
            }
            if (whatsApp != null)
            {
                viewModel.WhatsApp = whatsApp.valueAr;
            }
            return viewModel;
        }

        void ISettingRepository.UpsertAboutUs(string aboutUsAr, string aboutUsEn)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.AboutUs);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.html,
                valueAr = aboutUsAr,
                valueEn = aboutUsEn,
                ValueType = SD.AboutUs,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertCompanyEmail(string email)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyEmail);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.text,
                valueAr = email,
                valueEn = email,
                ValueType = SD.CompanyEmail,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertCompanyImage(string imagePathAr, string imagePathEn)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyImage);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.image,
                valueAr = imagePathAr,
                valueEn = imagePathEn,
                ValueType = SD.CompanyImage,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertCompanyInfo(string infoAr, string infoEn)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyInformation);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.html,
                valueAr = infoAr,
                valueEn = infoEn,
                ValueType = SD.CompanyInformation,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertCompanyPhone(string phone)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyPhone);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.phone,
                valueAr = phone,
                valueEn = phone,
                ValueType = SD.CompanyPhone,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertCompanyWhatsApp(string phone)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.CompanyWhatsApp);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.phone,
                valueAr = phone,
                valueEn = phone,
                ValueType = SD.CompanyWhatsApp,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertMission(string missionAr, string missionEn)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.Mission);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.html,
                valueAr = missionAr,
                valueEn = missionEn,
                ValueType = SD.Mission,
            };
            _db.Settings.Add(setting);
        }

        void ISettingRepository.UpsertVision(string visionAr, string visionEn)
        {
            var exist = _db.Settings.SingleOrDefault(x => x.ValueType == SD.Vision);
            if (exist != null)
            {
                _db.Settings.Remove(exist);
            }
            Setting setting = new Setting()
            {
                Type = (int)SettingType.html,
                valueAr = visionAr,
                valueEn = visionEn,
                ValueType = SD.Vision,
            };
            _db.Settings.Add(setting);
        }
    }
}

