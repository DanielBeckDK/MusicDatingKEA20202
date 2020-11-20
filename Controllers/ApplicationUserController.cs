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
            IQueryable<string> qGenres = from m in _context.Genres
                                    orderby m.GenreName
                                    select m.GenreName;

            var users = from x in _context.UserInstrument.Include(x => x.Instrument).Include(x=>x.ApplicationUser)
                        select x;   

    

            if (!String.IsNullOrEmpty(instrumentName) || (!String.IsNullOrEmpty(genreName) )
                {
                    users = users.Where(s => s.Instrument.Name.Contains(instrumentName));
                }

            var userInstrumentVm = new UserInstrumentVm
            {
                Instruments = new SelectList(await qInstrumentList.Distinct().ToListAsync()),
                User = await users.ToListAsync()
            };

            return View(userInstrumentVm);
        }
    }
}