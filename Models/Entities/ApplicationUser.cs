using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MusicDating.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

         public ICollection<UserInstrument> UserInstruments { get; set; }
    }
}