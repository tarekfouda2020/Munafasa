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
    public class OwnerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OwnerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var owners = _unitOfWork.Owner.GetAll(filter: (x)=>!x.Deleted);
            return View(owners);
        }

        public IActionResult UpSert(int? ownerId)
        {
            var owner = _unitOfWork.Owner.GetFirstOrDefault(x => x.Id == ownerId);
            return View(owner);
        }

        [HttpPost]
        public IActionResult UpSert(Owner owner)
        {
            if (ModelState.IsValid)
            {
                if (owner.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Owner.Update(owner);
                }
                else
                {

                    TempData["success"] = "Created Successfully";
                    owner.ProfileImage = "Images/default.png";
                    _unitOfWork.Owner.Add(owner);

                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(owner);
        }


        public IActionResult Delete(int ownerId)
        {
            var owner = _unitOfWork.Owner.GetFirstOrDefault(x => x.Id == ownerId);
            owner!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }
    }
}

