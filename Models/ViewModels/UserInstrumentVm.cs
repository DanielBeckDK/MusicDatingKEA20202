using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicDating.Models.Entities;

namespace MusicDating.Models.ViewModels {
    public class UserInstrumentVm {

        public List<UserInstrument> User { get; set; }
        public SelectList Instruments { get; set; }
        public string instrumentName { get; set; }
        public string SearchString { get; set; }
    }
}