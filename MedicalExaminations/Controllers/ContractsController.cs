using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExaminations.Controllers
{
    public class ContractsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
