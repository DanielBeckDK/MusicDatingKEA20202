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

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string instrumentName, string genreName)
        {
            IQueryable<string> qInstrumentList = from m in _context.Instruments
                                                 orderby m.Name
                                                 select m.Name;
            IQueryable<string> Genres = from m in _context.Genres
                                        orderby m.GenreName
                                        select m.GenreName;

            var users = from x in _context.ApplicationUser.Include(x => x.UserInstruments)
                        .ThenInclude(y => y.Instrument).Include(x => x.UserInstruments)
                        .ThenInclude(y => y.UserInstrumentGenres).ThenInclude(y => y.Genre)
                        select x;


            if (!String.IsNullOrEmpty(instrumentName) && String.IsNullOrEmpty(genreName))
            {
                users = from u in users
                        from g in u.UserInstruments
                        where g.Instrument.Name == instrumentName
                        select u;
            }
            if (!String.IsNullOrEmpty(instrumentName) && !String.IsNullOrEmpty(genreName))
            {
                users = from u in users
                        from g in u.UserInstruments
                        from ge in g.UserInstrumentGenres
                        where g.Instrument.Name == instrumentName && ge.Genre.GenreName == genreName
                        select u;
            }
            if (!String.IsNullOrEmpty(genreName) && String.IsNullOrEmpty(instrumentName))
            {
                users = from u in users
                        from g in u.UserInstruments
                        from ge in g.UserInstrumentGenres
                        where ge.Genre.GenreName == genreName
                        select u;
            }

            var userInstrumentVm = new UserInstrumentVm
            {
                Instruments = new SelectList(await qInstrumentList.Distinct().ToListAsync()),
                Genres = new SelectList(await Genres.Distinct().ToListAsync()),
                User = await users.Distinct().ToListAsync(),
                InstrumentName = instrumentName,
                GenreName = genreName
            };

            return View(userInstrumentVm);
        }
    }
}