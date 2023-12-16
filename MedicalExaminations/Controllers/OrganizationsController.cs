using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicalExaminations.Controllers
{
    public class OrganizationsController : Controller
    {
        AppDbContext db;
        public OrganizationsController(AppDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Organizations
                .Include(o => o.OrganizationType)
                .Include(o => o.OrganizationAttribute)
                .Include(o => o.Location)
        .ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Organization organization)
        {
            db.Organizations.Add(organization);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
