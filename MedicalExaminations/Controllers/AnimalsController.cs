using MedicalExaminations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MedicalExaminations.Controllers

{
    public class AnimalsController : Controller
    {
        AppDbContext db;

        public AnimalsController(AppDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.CanEditAnimalsRegistry = GlobalConfig.CurrentUser.PermissionManager.CanEditAnimalsRegistry;
            return View(await db.Animals.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Locations = new SelectList(db.Locations.ToList(), "Id", "Name");
            ViewBag.AnimalCategories = new SelectList(db.AnimalCategories.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Animal animal)
        {
            db.Animals.Add(animal);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
