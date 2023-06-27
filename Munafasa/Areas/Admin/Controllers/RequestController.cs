using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

        public IActionResult Delete(int requestId)
        {
            var request = _unitOfWork.Request.GetFirstOrDefault(x => x.Id == requestId);
            request!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }


    }
}

