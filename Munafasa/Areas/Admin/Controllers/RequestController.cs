using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RequestController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var requests = _unitOfWork.Request.GetAll(
                filter: (x)=>!x.Deleted,
                x=> x.Client, x=> x.Service,
                x=> x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract);
            return View(requests);
        }

        public IActionResult ContractRequests(int contractId)
        {
            var requests = _unitOfWork.Request.GetAll(
                filter: (x) => !x.Deleted && x.Client.ContractId == contractId,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract);
            return View(requests);
        }

        public IActionResult ClientRequests(int clientId)
        {
            var requests = _unitOfWork.Request.GetAll(
                filter: (x) => !x.Deleted && x.Client.Id == clientId,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract);
            return View(requests);
        }

        
        public IActionResult TechniciansRequests(int techId)
        {
            var requests = _unitOfWork.Request.GetAll(
                filter: (x) => !x.Deleted && x.TechnicianId == techId,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract);
            return View(requests);
        }

        public IActionResult ServiceRequests(int serviceId)
        {
            var requests = _unitOfWork.Request.GetAll(
                filter: (x) => !x.Deleted && x.ServiceId == serviceId,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract);
            return View(requests);
        }

        public IActionResult NewRequests()
        {
            var requests = _unitOfWork.Request.GetAll(filter: (x) => !x.Deleted && x.Status == (int)StatusEnumeration.New,
             x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract
                );
            return View(requests);
        }

        public IActionResult InProgressRequests()
        {
            var requests = _unitOfWork.Request.GetAll(filter: (x) => !x.Deleted && x.Status >= (int)StatusEnumeration.PendingOwnerApproval && x.Status <= (int)StatusEnumeration.TechnicalFinished,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract
                );
            return View(requests);
        }

        public IActionResult DoneRequests()
        {
            var requests = _unitOfWork.Request.GetAll(filter: (x) => !x.Deleted && x.Status == (int)StatusEnumeration.Done,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract
                );
            return View(requests);
        }

        public IActionResult CanceledRequests()
        {
            var requests = _unitOfWork.Request.GetAll(filter: (x) => !x.Deleted && x.Status == (int)StatusEnumeration.Canceled,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract
                );
            return View(requests);
        }

        public IActionResult Details(int requestId)
        {
            var request = _unitOfWork.Request.GetFirstOrDefault(x=> x.Id == requestId,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract
                );
            return View(request);
        }

        public IActionResult Edit(int requestId)
        {
            var request = _unitOfWork.Request.GetFirstOrDefault(x => x.Id == requestId,
                x => x.Client, x => x.Service,
                x => x.Technician,
                x => x.RequestImages,
                x => x.Client.Contract.Owner,
                x => x.Client.Contract
                )!;
            var technicans = _unitOfWork.Technicain.GetAll(x => !x.Deleted);
            RequestViewModel viewModel = new RequestViewModel()
            {
                Id = request.Id,
                AdditionalPrice = request.AdditionalPrice,
                Desc = request.Desc,
                IsUrget = request.IsUrget,
                OwnerNote = request.OwnerNote,
                RequestImages = request.RequestImages,
                TechnicianId = request.TechnicianId,
                TecnicianNote = request.TecnicianNote,
                Status = request.Status,
                Technicians = technicans.Select(x => new SelectListItem()
                {
                    Text = x.UserName,
                    Value = x.Id.ToString()
                })
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(RequestViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var request = _unitOfWork.Request.GetFirstOrDefault(x => x.Id == viewModel.Id)!;
                request.Id = viewModel.Id;
                request.AdditionalPrice = viewModel.AdditionalPrice;
                request.Desc = viewModel.Desc;
                request.IsUrget = viewModel.IsUrget;
                request.OwnerNote = viewModel.OwnerNote;
                request.RequestImages = viewModel.RequestImages;
                request.TechnicianId = viewModel.TechnicianId;
                request.TecnicianNote = viewModel.TecnicianNote;
                request.Status = viewModel.Status;
                _unitOfWork.Request.Update(request);
                _unitOfWork.Save();
                TempData["success"] = "Updated Successfuly";
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public IActionResult ChangeStatus(int requestId, int status)
        {
            var request = _unitOfWork.Request.GetFirstOrDefault(x => x.Id == requestId);
            request!.Status = status;
            _unitOfWork.Save();
            TempData["success"] = "Updated Successfuly";
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int requestId)
        {
            var request = _unitOfWork.Request.GetFirstOrDefault(x => x.Id == requestId);
            request!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult DeleteAttachment(int attachId)
        {
            var attacment = _unitOfWork.RequestImages.GetFirstOrDefault(x => x.Id == attachId);
            _unitOfWork.RequestImages.Remove(attacment!);
            _unitOfWork.Save();
            new FileHelper(_hostEnvironment).DeleteFile(attacment!.Url);
            return Json(new { success = true, msg = "Attachment Removed Successfuly" });
        }


    }
}

