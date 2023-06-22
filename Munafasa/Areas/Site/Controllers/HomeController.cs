using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Munafasa.Data.IRepositories;
using Munafasa.Models;
using Munafasa.Models.Tables;
using Munafasa.Models.ViewModels;

namespace Munafasa.Controllers;

[Area("Site")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        var settings = _getModel();
        return View(settings);
    }

    [HttpPost]
    public IActionResult Index(SettingViewModel viewModel)
    {
        var setting = _getModel();
        setting.ContactUs = viewModel.ContactUs;
        if (ModelState.IsValid)
        {
            _unitOfWork.Contact.Add(viewModel.ContactUs);
            _unitOfWork.Save();
            setting.ContactUs = new ContactUs();
            TempData["success"] = "Sent Successfully";
            return View(setting);
        }
        TempData["error"] = "Faild To Send";
        return View(setting);
    }

    SettingViewModel _getModel()
    {
        var settings =_unitOfWork.Setting.GetSettingViewModel();
        var services = _unitOfWork.Service.GetAll();
        var morals = _unitOfWork.Moral.GetAll();
        settings.Morals = morals.ToList();
        settings.Services = services.ToList();
        return settings;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

