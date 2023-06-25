using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Munafasa.Data.IRepositories;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Munafasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(IUnitOfWork unitofWork, IUserStore<ApplicationUser> userStore, UserManager<ApplicationUser> userManager)
        {
            _unitofWork = unitofWork;
            _userStore = userStore;
            _userManager = userManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            IEnumerable<ApplicationUser> users = _unitofWork.ApplicationUser.GetAll(filter: x=> x.Id != userId && !x.Deleted);

            return View(users);
        }

        public IActionResult Upsert(string? userId)
        {
            AdminViewModel viewModel = new AdminViewModel();
            if (userId != null)
            {
                var user = _unitofWork.ApplicationUser.GetFirstOrDefault(x => x.Id == userId)!;
                viewModel.Id = user.Id;
                viewModel.Email = user.Email!;
                viewModel.Name = user.Name;
                viewModel.Password = user.PasswordHash??"";
                viewModel.PhoneNumber = user.PhoneNumber!;
                return View(viewModel);
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(AdminViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Id!= null)
                {
                    var userExist = _unitofWork.ApplicationUser.GetFirstOrDefault(x => x.Email == viewModel.Email && x.Id != viewModel.Id);
                    if (userExist != null)
                    {
                        ModelState.AddModelError("Email", "This Email Already Exist");
                        return View(viewModel);

                    }

                    var user = _unitofWork.ApplicationUser.GetFirstOrDefault(x => x.Id == viewModel.Id)!;
                    user!.Email = viewModel.Email;
                    user.Name = viewModel.Name;
                    user.PhoneNumber = viewModel.PhoneNumber;
                    await _userManager.UpdateAsync(user);
                    TempData["success"] = "Updated Successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {

                    var userExist = _unitofWork.ApplicationUser.GetFirstOrDefault(x => x.Email == viewModel.Email);
                    if (userExist != null)
                    {
                        ModelState.AddModelError("Email", "This Email Already Exist");
                        return View(viewModel);

                    }

                    ApplicationUser user = new ApplicationUser()
                    {
                        Email = viewModel.Email,
                        Name = viewModel.Name,
                        PhoneNumber = viewModel.PhoneNumber,
                        UserName = viewModel.Email,
                        TwoFactorEnabled = false,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                    };
                    //await _userStore.SetUserNameAsync(user, user.Email, CancellationToken.None);
                    var result = await _userManager.CreateAsync(user, viewModel.Password);

                    if (result.Succeeded)
                    {
                        TempData["success"] = "Created Successfully";
                        return RedirectToAction(nameof(Index));
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("Errors", error.Description);
                    }
                }
              
            }
            return View(viewModel);
        }

        public IActionResult Delete(string userId)
        {
            var user = _unitofWork.ApplicationUser.GetFirstOrDefault(x => x.Id == userId);
            user!.Deleted = true;
            _unitofWork.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ChangeStatus(string userId)
        {
            _unitofWork.ApplicationUser.ChangeStatus(userId);
            _unitofWork.Save();
            return RedirectToAction(nameof(Index));
        }

    }
}

