using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExaminations.Controllers
{
    public class ContractsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CanEditContractsRegistry = GlobalConfig.CurrentUser.PermissionManager.CanEditOrganizationsRegistry;
            return View();
        }
    }
}
