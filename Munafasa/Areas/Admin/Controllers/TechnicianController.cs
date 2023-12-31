﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TechnicianController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TechnicianController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var technicians = _unitOfWork.Technicain.GetAll(filter: (x)=> !x.Deleted, x => x.TechnicianServices, x => x.Requests);
            return View(technicians);
        }

        public IActionResult ServiceTechnicians(int serviceId)
        {
            var techServices = _unitOfWork.TechServices.GetAll(filter: (x) => x.ServiceId == serviceId, x => x.Service, x => x.Technician);
            var technicians = techServices.Select(x => x.Technician);
            return View(technicians);
        }

        public IActionResult Details(int techId)
        {
            var technician = _unitOfWork.Technicain.GetFirstOrDefault(filter: (x) => x.Id == techId, x => x.TechnicianServices, x => x.Requests);
            return View(technician);
        }

        public IActionResult UpSert(int? techId)
        {
            Technician technician = new Technician();
            var services = _unitOfWork.Service.GetAll();
            if (techId != null)
            {
                technician = _unitOfWork.Technicain.GetFirstOrDefault(x => x.Id == techId, x=> x.TechnicianServices)!;
            }
            TechnicianViewModel viewModel = new TechnicianViewModel()
            {
                Technician = technician,
                Services = services.Select(x => new SelectListItem()
                {
                    Text = x.NameEn,
                    Value = x.Id.ToString(),
                }).ToList(),
            };
            if (technician.TechnicianServices != null)
            {
                viewModel.TechServices = technician.TechnicianServices.Select(x => x.Id).ToList();
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpSert(TechnicianViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var technician = viewModel.Technician;
                if (viewModel.PassportImage != null)
                {
                    string imagePath = await new FileHelper(_hostEnvironment)
                        .SaveFile(path: "Images/Tech/", file: viewModel.PassportImage, prevFile: technician.PassportImage);
                    technician.PassportImage = imagePath;
                }

                if (technician.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Technicain.Update(technician);
                }
                else
                {
                    TempData["success"] = "Created Successfully";
                    technician.ProfileImage = "Images/default.png";
                    _unitOfWork.Technicain.Add(technician);

                }
                _unitOfWork.Save();
                var prevServices = _unitOfWork.TechServices.GetAll(filter: (x) => x.TechnicianId == technician.Id);
                _unitOfWork.TechServices.RemoveRang(prevServices);
                foreach (var item in viewModel.TechServices)
                {
                    TechnicianService technicianService = new TechnicianService()
                    {
                        ServiceId = item,
                        TechnicianId = technician.Id
                    };
                    _unitOfWork.TechServices.Add(technicianService);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            var services = _unitOfWork.Service.GetAll();
            viewModel.Services = services.Select(x => new SelectListItem()
            {
                Text = x.NameEn,
                Value = x.Id.ToString(),
            }).ToList();
            return View(viewModel);
        }

        public IActionResult Delete(int techId)
        {
            var technician = _unitOfWork.Technicain.GetFirstOrDefault(x => x.Id == techId);
            technician!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }
    }
}

