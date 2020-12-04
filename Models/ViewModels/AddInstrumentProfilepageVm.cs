using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicDating.Models.Entities;

namespace MusicDating.Models.ViewModels {
    public class AddInstrumentProfilePageVm {
        public ApplicationUser ApplicationUser { get; set; }
        public SelectList Instruments { get; set; }
        public Instrument Instrument { get; set; }
        public SelectList Genres { get; set; }
        public Genre Genre { get; set; }
        [RegularExpression(@"^\d{1,5}$", ErrorMessage="Level must be between 1-5")]
        public int Level { get; set; }
    }
}