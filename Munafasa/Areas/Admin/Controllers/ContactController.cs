using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var contacts = _unitOfWork.Contact.GetAll();
            return View(contacts);
        }

        public IActionResult Delete(int contactId)
        {
            var contact = _unitOfWork.Contact.GetFirstOrDefault(x => x.Id == contactId);
            _unitOfWork.Contact.Remove(contact!);
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }


    }
}

