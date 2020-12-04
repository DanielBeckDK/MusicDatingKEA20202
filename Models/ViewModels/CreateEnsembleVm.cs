using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicDating.Models.Entities;

namespace MusicDating.Models.ViewModels {
    public class CreateEnsembleVm {
    public SelectList Genres { get; set; }
    public Genre Genre { get; set; }
    public ApplicationUser user { get; set; }
    public string EnsembleDescription { get; set; }
    }
}