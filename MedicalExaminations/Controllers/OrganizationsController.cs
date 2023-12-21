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
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Organization organization)
        {
            db.Organizations.Add(organization);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Locations = new SelectList(db.Locations.ToList(), "Id", "Name");
            ViewBag.OrganizationTypes = new SelectList(db.OrganizationTypes.ToList(), "Id", "Name");
            ViewBag.OrganizationAttributes = new SelectList(db.OrganizationAttributes.ToList(), "Id", "Name");
            if (id != null)
            {
                Organization? organization = await db.Organizations.FirstOrDefaultAsync(p => p.Id == id);
                if (organization != null) return View(organization);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Organization organization)
        {
            db.Organizations.Update(organization);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Organization? organization = await db.Organizations.FirstOrDefaultAsync(p => p.Id == id);
                if (organization != null)
                {
                    db.Organizations.Remove(organization);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
