using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicDating.Models.Entities;

namespace MusicDating.Models.ViewModels {
    public class ProfilePageVm {
       
        public IEnumerable<UserInstrument> UserInstruments { get; set; }
   
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<UserEnsemble> UserEnsembles { get; set; }
    }
}