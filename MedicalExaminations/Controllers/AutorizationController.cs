using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MedicalExaminations.Controllers
{
    public class AutorizationController : Controller
    {
        private readonly ILogger<AutorizationController> _logger;

        public AutorizationController(ILogger<AutorizationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}