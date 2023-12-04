using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExaminations.Controllers

{
    public class AnimalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
