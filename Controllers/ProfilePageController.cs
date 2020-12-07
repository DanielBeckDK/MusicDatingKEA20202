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
        public async Task<IActionResult> AddInstrument(){
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            /* IQueryable<Instrument> qInstrumentList = from m in _context.Instruments
                                                 orderby m.Name
                                                 select m; */
            /* var returnInstruments = new SelectList(await _context.Instruments.ToListAsync()); */
            var AddInstrumentProfilePageVm = new AddInstrumentProfilePageVm()
            {
                ApplicationUser = applicationUser,
                Genres = new SelectList(_context.Genres, "GenreId", "GenreName"),
                Instruments = new SelectList(_context.Instruments, "InstrumentId", "Name")
                
        };
            return View(AddInstrumentProfilePageVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddInstrument(int level, IEnumerable<int> genres, int instrument)
        {
           
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            UserInstrument userInstrument = new UserInstrument();
            userInstrument.Id = applicationUser.Id;
            userInstrument.InstrumentId = instrument;
            userInstrument.Level = level;
            _context.Add(userInstrument);
            foreach (var item in genres)
            {
                UserInstrumentGenre userInstrumentGenre = new UserInstrumentGenre();
                userInstrumentGenre.Id = applicationUser.Id;
                userInstrumentGenre.GenreId = item;
                userInstrumentGenre.InstrumentId = instrument;
                _context.Add(userInstrumentGenre);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CreateEnsemble()
        {
            
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            var createEnsembleVm = new CreateEnsembleVm()
            {
                Genres = new SelectList(_context.Genres, "GenreId", "GenreName")
            };

            return View(createEnsembleVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEnsemble(IEnumerable<int> genres, string EnsembleName, string EnsembleDescription)
        {
            if(!genres.Any()){
                ModelState.AddModelError("Checkbox", "No Genres associated!");
                //return RedirectToAction(nameof(CreateEnsemble));
                    var createEnsembleVm = new CreateEnsembleVm()
                    {
                        Genres = new SelectList(_context.Genres, "GenreId", "GenreName")
                    };
                    return View(createEnsembleVm);
            }
            
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            Ensemble ensemble = new Ensemble();
            ensemble.Id = applicationUser.Id;
            ensemble.EnsembleName = EnsembleName;
            ensemble.EnsembleDescription = EnsembleDescription;
            _context.Add(ensemble);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                ModelState.AddModelError("Unique", "Ensemble already exist with this name!");
                var createEnsembleVm = new CreateEnsembleVm()
                    {
                        Genres = new SelectList(_context.Genres, "GenreId", "GenreName")
                    };
                return View(createEnsembleVm);
            }
            
            foreach (var item in genres)
            {
                GenreEnsemble genreEnsemble = new GenreEnsemble();
                genreEnsemble.GenreId = item;
                genreEnsemble.EnsembleId = ensemble.EnsembleId;
                _context.Add(genreEnsemble);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> EditEnsemble(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

            var ensemble = await _context.Ensembles
                 .FirstOrDefaultAsync(m => m.EnsembleId == id);
            IQueryable<int> qGenreEnsemblesId = from m in _context.GenreEnsemble
                                                where m.EnsembleId == id
                                                select m.GenreId;

            var editEnsemblevm = new EditEnsembleVm()
            {
                Genres = new SelectList(_context.Genres, "GenreId", "GenreName"),
                genreIDs = await qGenreEnsemblesId.ToListAsync(),
                Ensemble = ensemble
            };

            if (ensemble == null)
             {
                 return NotFound();
             }

             return View(editEnsemblevm);
         } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEnsemble(int id,IEnumerable<int> genres, string EnsembleName, string EnsembleDescription)
        {
            Ensemble ensemble = new Ensemble();
            
            ensemble.EnsembleName = EnsembleName;
            ensemble.EnsembleDescription = EnsembleDescription;
            _context.Update(ensemble);

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
        // GET: Instruments/Create
        /* public IActionResult Create()
        {
            return View();
        }

        // POST: Instruments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
       

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
