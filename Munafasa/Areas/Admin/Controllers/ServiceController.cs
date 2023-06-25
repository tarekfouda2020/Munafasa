using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ServiceController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var services = _unitOfWork.Service.GetAll(filter:(x)=> !x.Deleted);
            return View(services);
        }

        public IActionResult UpSert(int? serviceId)
        {
            var service = _unitOfWork.Service.GetFirstOrDefault(x => x.Id == serviceId);
            return View(service);
        }

        [HttpPost]
        public async Task<IActionResult> UpSert(Service service, IFormFile? image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    string imagePath = await new FileHelper(_hostEnvironment)
                        .SaveFile(path: "Images/Services/", file: image, prevFile: service.ImageUrl);
                    service.ImageUrl = imagePath;
                }

                if (service.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Service.Update(service);
                }
                else
                {
                    if (image == null)
                    {
                        ModelState.AddModelError("Errors", "Please add service image");
                        return View(service);
                    }

                    TempData["success"] = "Created Successfully";
                    _unitOfWork.Service.Add(service);

                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }


        public IActionResult Delete(int serviceId)
        {
            var service = _unitOfWork.Service.GetFirstOrDefault(x => x.Id == serviceId);
            service!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }
    }
}

