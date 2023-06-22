using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public SettingController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var setting = _unitOfWork.Setting.GetSiteSettingModell();

            return View(setting);
        }

        [HttpPost]
        public async Task<IActionResult> Index(SiteSettingModel viewModel, IFormFile? image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    string imagePath = await new FileHelper(_hostEnvironment)
                        .SaveFile(path: "Images/Setting/", file: image, prevFile: viewModel.Image);
                    _unitOfWork.Setting.UpsertCompanyImage(imagePath, imagePath);
                }

                _unitOfWork.Setting.UpsertCompanyPhone(viewModel.Phone);
                _unitOfWork.Setting.UpsertCompanyWhatsApp(viewModel.WhatsApp);
                _unitOfWork.Setting.UpsertCompanyEmail(viewModel.Email);
                _unitOfWork.Setting.UpsertCompanyInfo(viewModel.CompanyInfoAr, viewModel.CompanyInfoEn);

                _unitOfWork.Save();
                TempData["success"] = "Updated Successfully";
            }
            return View(viewModel);
        }


        public IActionResult About()
        {
            var about = _unitOfWork.Setting.GetFirstOrDefault(x => x.ValueType == SD.AboutUs);
            LocalizedModel localizedModel = new LocalizedModel();
            if (about != null)
            {
                localizedModel.Ar = about.valueAr;
                localizedModel.En = about.valueEn;
            }
            return View(localizedModel);
        }

        [HttpPost]
        public IActionResult About(LocalizedModel localizedModel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Setting.UpsertAboutUs(localizedModel.Ar, localizedModel.En);
                _unitOfWork.Save();
                TempData["success"] = "Updated Successfully";
            }
            return View(localizedModel);
        }

        public IActionResult Mission()
        {
            var about = _unitOfWork.Setting.GetFirstOrDefault(x => x.ValueType == SD.Mission);
            LocalizedModel localizedModel = new LocalizedModel();
            if (about != null)
            {
                localizedModel.Ar = about.valueAr;
                localizedModel.En = about.valueEn;
            }
            return View(localizedModel);
        }

        [HttpPost]
        public IActionResult Mission(LocalizedModel localizedModel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Setting.UpsertMission(localizedModel.Ar, localizedModel.En);
                _unitOfWork.Save();
                TempData["success"] = "Updated Successfully";
            }
            return View(localizedModel);
        }

        public IActionResult Vision()
        {
            var about = _unitOfWork.Setting.GetFirstOrDefault(x => x.ValueType == SD.Vision);
            LocalizedModel localizedModel = new LocalizedModel();
            if (about != null)
            {
                localizedModel.Ar = about.valueAr;
                localizedModel.En = about.valueEn;
            }
            return View(localizedModel);
        }

        [HttpPost]
        public IActionResult Vision(LocalizedModel localizedModel)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Setting.UpsertVision(localizedModel.Ar, localizedModel.En);
                _unitOfWork.Save();
                TempData["success"] = "Updated Successfully";
            }
            return View(localizedModel);
        }


    }
}

