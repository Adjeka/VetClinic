using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExaminations.Controllers
{
    public class OrganizationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
