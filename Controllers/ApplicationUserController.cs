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
        public async Task<IActionResult> Index(string instrumentName){
            IQueryable<string> query = from m in _context.Instruments
                                    orderby m.Name
                                    select m.Name;

            var users = from x in _context.UserInstrument.Include(x => x.Instrument).Include(x=>x.ApplicationUser)
                        select x;

            if (!String.IsNullOrEmpty(instrumentName))
                {
                    users = users.Where(s => s.Instrument.Name.Contains(instrumentName));
                }

            var userInstrumentVm = new UserInstrumentVm
            {
                Instruments = new SelectList(await query.Distinct().ToListAsync()),
                User = await users.ToListAsync()
            };

            return View(userInstrumentVm);
        }
    }
}