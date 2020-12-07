using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicDating.Models.Entities;

namespace MusicDating.Models.ViewModels {
    public class EditEnsembleVm {
    public SelectList Genres { get; set; }
    public Ensemble Ensemble { get; set; }
    public List<int> genreIDs { get; set; }
    }
}