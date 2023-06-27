using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var clients = _unitOfWork.Client.GetAll(filter: (x)=> !x.Deleted, x=> x.Contract);
            return View(clients);
        }

        public IActionResult Details(int clientId)
        {
            var clients = _unitOfWork.Client.GetFirstOrDefault(filter: (x) => x.Id == clientId, x => x.Contract, x=> x.Requests, x => x.Contract.Owner);
            return View(clients);
        }

        public IActionResult UpSert(int? clientId)
        {
            Client client = new Client();
            var contracts = _unitOfWork.Contract.GetAll();
            if (clientId != null)
            {
                client = _unitOfWork.Client.GetFirstOrDefault(x => x.Id == clientId, x => x.Contract)!;
            }
            ClientViewModel viewModel = new ClientViewModel()
            {
                Client = client,
                Contracts = contracts.Select(x=> new SelectListItem()
                {
                    Text = x.NameEn,
                    Value = x.Id.ToString(),
                }).ToList(),
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpSert(ClientViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var client = viewModel.Client;
                if (client.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Client.Update(client);
                }
                else
                {

                    TempData["success"] = "Created Successfully";
                    client.ProfileImage = "Images/default.png";
                    _unitOfWork.Client.Add(client);

                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            var contracts = _unitOfWork.Contract.GetAll();
            viewModel.Contracts = contracts.Select(x => new SelectListItem()
            {
                Text = x.NameEn,
                Value = x.Id.ToString(),
            }).ToList();
            return View(viewModel);
        }

        public IActionResult Delete(int clientId)
        {
            var client = _unitOfWork.Client.GetFirstOrDefault(x => x.Id == clientId);
            client!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }
    }
}

