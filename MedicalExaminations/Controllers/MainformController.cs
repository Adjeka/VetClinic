using Microsoft.AspNetCore.Mvc;

namespace MedicalExaminations.Controllers
{
    public class MainformController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
