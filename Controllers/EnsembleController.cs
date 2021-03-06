using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicDating.Data;
using MusicDating.Models.Entities;

namespace MusicDating.Controllers
{
    public class EnsembleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnsembleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ensemble
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ensembles.ToListAsync());
        }

        // GET: Ensemble/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ensemble = await _context.Ensembles
                .FirstOrDefaultAsync(m => m.EnsembleId == id);
            if (ensemble == null)
            {
                return NotFound();
            }

            return View(ensemble);
        }

        // GET: Ensemble/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ensemble/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnsembleId,EnsembleName,EnsembleDescription")] Ensemble ensemble)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ensemble);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ensemble);
        }

        // GET: Ensemble/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ensemble = await _context.Ensembles.FindAsync(id);
            if (ensemble == null)
            {
                return NotFound();
            }
            return View(ensemble);
        }

        // POST: Ensemble/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnsembleId,EnsembleName,EnsembleDescription")] Ensemble ensemble)
        {
            if (id != ensemble.EnsembleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ensemble);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnsembleExists(ensemble.EnsembleId))
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
            return View(ensemble);
        }

        // GET: Ensemble/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ensemble = await _context.Ensembles
                .FirstOrDefaultAsync(m => m.EnsembleId == id);
            if (ensemble == null)
            {
                return NotFound();
            }

            return View(ensemble);
        }

        // POST: Ensemble/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ensemble = await _context.Ensembles.FindAsync(id);
            _context.Ensembles.Remove(ensemble);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnsembleExists(int id)
        {
            return _context.Ensembles.Any(e => e.EnsembleId == id);
        }
    }
}
