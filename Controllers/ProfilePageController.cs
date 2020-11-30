using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicDating.Data;
using MusicDating.Models.Entities;
using MusicDating.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MusicDating.Controllers
{
    [Authorize]
    public class ProfilePageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProfilePageController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            
            _context = context;
        }
        [AllowAnonymous]
        // GET: Instruments
        public async Task<IActionResult> Index()
        {
            
            
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            //Logik der tilgår databasen og finder instrumenter der tilhører denne bruger
            var user = from x in _context.ApplicationUser.Include(x => x.UserInstruments)
                        .ThenInclude(y => y.Instrument).Include(x => x.UserInstruments)
                        .ThenInclude(y => y.UserInstrumentGenres).ThenInclude(y => y.Genre)
                        .Include(a => a.OwnedEnsembles) where x.Id == applicationUser.Id
                        select x;
        
            var OURuser = await user.ToListAsync();
            return View(OURuser);
        }
        public async Task<IActionResult> AddInstrument(Instrument instrument){
            
            IQueryable<string> qInstrumentList = from m in _context.Instruments
                                                 orderby m.Name
                                                 select m.Name;
            var returnInstruments = new SelectList(await qInstrumentList.Distinct().ToListAsync());
            return View(returnInstruments);
        }
       

        // GET: Instruments/Details/5
        /*  public async Task<IActionResult> Details(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var instrument = await _context.Instruments
                 .FirstOrDefaultAsync(m => m.InstrumentId == id);
             if (instrument == null)
             {
                 return NotFound();
             }

             return View(instrument);
         } */

        // GET: Instruments/Create
        /* public IActionResult Create()
        {
            return View();
        }

        // POST: Instruments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstrumentId,Name")] Instrument instrument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instrument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instrument);
        }

        // GET: Instruments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrument = await _context.Instruments.FindAsync(id);
            if (instrument == null)
            {
                return NotFound();
            }
            return View(instrument);
        }

        // POST: Instruments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstrumentId,Name")] Instrument instrument)
        {
            if (id != instrument.InstrumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instrument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstrumentExists(instrument.InstrumentId))
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
            return View(instrument);
        }

        // GET: Instruments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrument = await _context.Instruments
                .FirstOrDefaultAsync(m => m.InstrumentId == id);
            if (instrument == null)
            {
                return NotFound();
            }

            return View(instrument);
        }

        // POST: Instruments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instrument = await _context.Instruments.FindAsync(id);
            _context.Instruments.Remove(instrument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstrumentExists(int id)
        {
            return _context.Instruments.Any(e => e.InstrumentId == id);
        }
    } */
    }
}
