using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MedicalExaminations.Models;

namespace MedicalExaminations.Controllers
{
    public class MedicalExaminationsController : Controller
    {
        private readonly AppDbContext _context;

        public MedicalExaminationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: MedicalExaminations
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.MedicalExaminations.Include(m => m.Animal).Include(m => m.Contract).Include(m => m.VetClinic);
            return View(await appDbContext.ToListAsync());
        }

        // GET: MedicalExaminations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MedicalExaminations == null)
            {
                return NotFound();
            }

            var medicalExamination = await _context.MedicalExaminations
                .Include(m => m.Animal)
                .Include(m => m.Contract)
                .Include(m => m.VetClinic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalExamination == null)
            {
                return NotFound();
            }

            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Create
        public IActionResult Create()
        {
            ViewData["AnimalId"] = new SelectList(_context.Animals, "Id", "Id");
            ViewData["ContractId"] = new SelectList(_context.Contracts, "Id", "Id");
            ViewData["VetClinicId"] = new SelectList(_context.Organizations, "Id", "Name");
            return View();
        }

        // POST: MedicalExaminations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AnimalId,BehaviourFeatures,AnimalCondition,BodyTemperature,SkinCovers,WoolCondition,Injuries,EmergencyHelpRequired,Diagnosis,ActionsTaken,TreatmentPrescribed,ExaminationDate,VeterinarianFullName,VeterinarianPosition,VetClinicId,ContractId")] MedicalExamination medicalExamination)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalExamination);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.Animals, "Id", "Id", medicalExamination.AnimalId);
            ViewData["ContractId"] = new SelectList(_context.Contracts, "Id", "Id", medicalExamination.ContractId);
            ViewData["VetClinicId"] = new SelectList(_context.Organizations, "Id", "Name", medicalExamination.VetClinicId);
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MedicalExaminations == null)
            {
                return NotFound();
            }

            var medicalExamination = await _context.MedicalExaminations.FindAsync(id);
            if (medicalExamination == null)
            {
                return NotFound();
            }
            ViewData["AnimalId"] = new SelectList(_context.Animals, "Id", "Id", medicalExamination.AnimalId);
            ViewData["ContractId"] = new SelectList(_context.Contracts, "Id", "Id", medicalExamination.ContractId);
            ViewData["VetClinicId"] = new SelectList(_context.Organizations, "Id", "Name", medicalExamination.VetClinicId);
            return View(medicalExamination);
        }

        // POST: MedicalExaminations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AnimalId,BehaviourFeatures,AnimalCondition,BodyTemperature,SkinCovers,WoolCondition,Injuries,EmergencyHelpRequired,Diagnosis,ActionsTaken,TreatmentPrescribed,ExaminationDate,VeterinarianFullName,VeterinarianPosition,VetClinicId,ContractId")] MedicalExamination medicalExamination)
        {
            if (id != medicalExamination.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalExamination);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalExaminationExists(medicalExamination.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.Animals, "Id", "Id", medicalExamination.AnimalId);
            ViewData["ContractId"] = new SelectList(_context.Contracts, "Id", "Id", medicalExamination.ContractId);
            ViewData["VetClinicId"] = new SelectList(_context.Organizations, "Id", "Name", medicalExamination.VetClinicId);
            return View(medicalExamination);
        }

        // GET: MedicalExaminations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MedicalExaminations == null)
            {
                return NotFound();
            }

            var medicalExamination = await _context.MedicalExaminations
                .Include(m => m.Animal)
                .Include(m => m.Contract)
                .Include(m => m.VetClinic)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalExamination == null)
            {
                return NotFound();
            }

            return View(medicalExamination);
        }

        // POST: MedicalExaminations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MedicalExaminations == null)
            {
                return Problem("Entity set 'AppDbContext.MedicalExaminations'  is null.");
            }
            var medicalExamination = await _context.MedicalExaminations.FindAsync(id);
            if (medicalExamination != null)
            {
                _context.MedicalExaminations.Remove(medicalExamination);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalExaminationExists(int id)
        {
          return (_context.MedicalExaminations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
