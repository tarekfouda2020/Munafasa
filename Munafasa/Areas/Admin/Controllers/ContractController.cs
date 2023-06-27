using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using Munafasa.Utilities;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContractController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ContractController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var contracts = _unitOfWork.Contract.GetAll(filter: (x)=> !x.Deleted,
                x=> x.Owner,
                x => x.ContractServices,
                x => x.Attacments,
                x => x.Cheques,
                x => x.Clients,
                x => x.Requests
                );
            return View(contracts);
        }

        public IActionResult OwnerContracts(int ownerId)
        {
            var contracts = _unitOfWork.Contract.GetAll(filter: (x) => !x.Deleted && x.OwnerId == ownerId,
                x => x.Owner,
                x => x.ContractServices,
                x => x.Attacments,
                x => x.Cheques,
                x => x.Clients,
                x => x.Requests
                );
            return View(contracts);
        }

        public IActionResult UpSert(int? contractId)
        {
            Contract contract = new Contract();
            if (contractId != null)
            {
                contract = _unitOfWork.Contract.GetFirstOrDefault(x => x.Id == contractId,
                             x => x.Owner,
                x => x.ContractServices,
                x => x.Attacments,
                x => x.Cheques,
                x => x.Requests
                    )!;
            }
            var owners = _unitOfWork.Owner.GetAll();
            ContractViewModel viewModel = new ContractViewModel()
            {
                Contract = contract,
                Owners = owners.Select(x=> new SelectListItem
                {
                    Text = x.UserName,
                    Value = x.Id.ToString(),
                }),
            };
            return View(viewModel);
        }

        public IActionResult Details(int contractId)
        {
            Contract contract = _unitOfWork.Contract.GetFirstOrDefault(x => x.Id == contractId,
                             x => x.Owner,
                x => x.ContractServices,
                x => x.Attacments,
                x => x.Cheques,
                 x => x.Clients,
                x => x.Requests
                    )!;
            return View(contract);
        }

        [HttpPost]
        public async Task<IActionResult> UpSert(ContractViewModel viewModel, List<IFormFile>? attachments)
        {
            if (ModelState.IsValid && viewModel.Contract.OwnerId != 0)
            {
                var contract = viewModel.Contract;
                if (contract.Id != 0)
                {
                    TempData["success"] = "Updated Successfully";
                    _unitOfWork.Contract.Update(contract);
                }
                else
                {
                    TempData["success"] = "Created Successfully";
                    contract.ContractNumber = DateTime.Now.Year.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Microsecond.ToString();
                    _unitOfWork.Contract.Add(contract);
                }
                _unitOfWork.Save();
                if (attachments?.Count != 0 && attachments != null)
                {
                   
                    foreach (var file in attachments)
                    {
                        string imagePath = await new FileHelper(_hostEnvironment)
                            .SaveFile(path: "Images/Contracts/", file: file);
                        var attach = new ContractAttacments()
                        {
                            ContrctId = contract.Id,
                            Url = imagePath,
                        };
                        _unitOfWork.ContractAttachment.Add(attach);
                    }

                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            if (viewModel.Contract.OwnerId == 0)
            {
                ModelState.AddModelError("OwnertId","Owner filed is required");
            }
            var owners = _unitOfWork.Owner.GetAll();
            viewModel.Owners = owners.Select(x => new SelectListItem
            {
                Text = x.UserName,
                Value = x.Id.ToString(),
            });
            return View(viewModel);
        }


        public IActionResult Delete(int contractId)
        {
            var contract = _unitOfWork.Contract.GetFirstOrDefault(x => x.Id == contractId);
            contract!.Deleted = true;
            _unitOfWork.Save();
            TempData["success"] = "Removed Successfuly";
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult DeleteAttachment(int attachId)
        {
            var attacment = _unitOfWork.ContractAttachment.GetFirstOrDefault(x => x.Id == attachId);
            _unitOfWork.ContractAttachment.Remove(attacment!);
            _unitOfWork.Save();
            new FileHelper(_hostEnvironment).DeleteFile(attacment!.Url);
            return Json(new { success = true, msg = "Attachment Removed Successfuly" });
        }
    }
}

