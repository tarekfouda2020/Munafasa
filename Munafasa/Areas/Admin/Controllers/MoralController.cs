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
    public class MoralController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public MoralController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var morals = _unitOfWork.Moral.GetAll();
            return View(morals);
        }

        public IActionResult UpSert(int? moralId)
        {
            var moral = _unitOfWork.Moral.GetFirstOrDefault(x => x.Id == moralId);
            return View(moral);
        }

        [HttpPost]
        public async Task<IActionResult> UpSert(Moral moral, IFormFile? image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    string imagePath = await new FileHelper(_hostEnvironment)
                        .SaveFile(path: "Images/Morals/", file: image, prevFile: moral.Image);
                    moral.Image = imagePath;
                }

                if (moral.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Moral.Update(moral);
                }
                else
                {
                    if (image == null)
                    {
                        ModelState.AddModelError("Errors", "Please add service image");
                        return View(moral);
                    }

                    TempData["success"] = "Created Successfully";
                    _unitOfWork.Moral.Add(moral);

                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(moral);
        }


        public IActionResult Delete(int moralId)
        {
            var service = _unitOfWork.Moral.GetFirstOrDefault(x => x.Id == moralId);
            _unitOfWork.Moral.Remove(service!);
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }
    }
}

