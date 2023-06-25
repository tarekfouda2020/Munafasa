using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChequeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public ChequeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(int contractId)
        {
            var cheques = _unitOfWork.Cheque.GetAll(filter: (x) => !x.Deleted);
            ViewBag.contractId = contractId;
             return View(cheques);
        }

        public IActionResult UpSert(int contractId, int? chequeId)
        {
            Cheque cheque = new Cheque();
            cheque.ContractId = contractId;
            if (chequeId != null)
            {
                cheque = _unitOfWork.Cheque.GetFirstOrDefault(x => x.Id == chequeId)!;
            }
            return View(cheque);
        }

        [HttpPost]
        public IActionResult UpSert(Cheque cheque)
        {
            if (ModelState.IsValid)
            {
                if (cheque.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Cheque.Update(cheque);
                }
                else
                {

                    TempData["success"] = "Created Successfully";
                    _unitOfWork.Cheque.Add(cheque);

                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(cheque);
        }

        public IActionResult Delete(int chequeId)
        {
            var client = _unitOfWork.Cheque.GetFirstOrDefault(x => x.Id == chequeId);
            client!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }
    }
}

