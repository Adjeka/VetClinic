using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewBag.Locations = new SelectList(db.Locations.ToList(), "Id", "Name");
            ViewBag.OrganizationTypes = new SelectList(db.OrganizationTypes.ToList(), "Id", "Name");
            ViewBag.OrganizationAttributes = new SelectList(db.OrganizationAttributes.ToList(), "Id", "Name");
            return View("CreateView");
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
