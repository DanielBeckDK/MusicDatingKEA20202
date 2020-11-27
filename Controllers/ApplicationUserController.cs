using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicDating.Data;
using MusicDating.Models.Entities;
using MusicDating.Models.ViewModels;

namespace MusicDating.Controllers
{
    public class ApplicationUserController : Controller
    { 
        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context){
            _context = context;
        }
        public async Task<IActionResult> Index(string instrumentName, string genreName){
            IQueryable<string> qInstrumentList = from m in _context.Instruments
                                    orderby m.Name
                                    select m.Name;
            IQueryable<string> Genres = from m in _context.Genres
                                    orderby m.GenreName
                                    select m.GenreName;

            var users = from x in _context.ApplicationUser.Include(x => x.UserInstruments).ThenInclude(x=>x.UserInstrumentGenres).ThenInclude(x=>x.UserInstrument).Include(x=>x.Genre)
                        select x;   

    

            if (!String.IsNullOrEmpty(instrumentName))
                {
                    users = users.Where(s => s.Instrument.Name.Contains(instrumentName));
                    
                }
            if (!String.IsNullOrEmpty(genreName))
                {
                    
                    users = users.Where(s => s.Genre.GenreName.Contains(genreName));
                }

            var userInstrumentVm = new UserInstrumentVm
            {
                Instruments = new SelectList(await qInstrumentList.Distinct().ToListAsync()),
                Genres = new SelectList(await Genres.Distinct().ToListAsync()),
                User = await users.ToListAsync()
            };

            return View(userInstrumentVm);
        }
    }
}