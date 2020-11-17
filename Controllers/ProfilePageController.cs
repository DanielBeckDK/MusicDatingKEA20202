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
using Microsoft.AspNetCore.Identity;

namespace MusicDating.Controllers
{
    [Authorize]
    public class ProfilePageController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        public ProfilePageController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            // string userEmail = applicationUser?.Email; // will give the user's Email
            return View(applicationUser);

        }
        private readonly ApplicationDbContext _context;



        // // GET: Instruments/Details/5
        // public async Task<IActionResult> Details(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var instrument = await _context.Instruments
        //         .FirstOrDefaultAsync(m => m.InstrumentId == id);
        //     if (instrument == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(instrument);
        // }

        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var instrument = await _context.Instruments.FindAsync(id);
        //     if (instrument == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(instrument);
        // }       
    }
}
