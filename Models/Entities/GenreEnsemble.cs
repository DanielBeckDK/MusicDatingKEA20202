using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicDating.Models.Entities 
{
    public class GenreEnsemble 
    {
        public int EnsembleId { get; set; }
        public Ensemble Ensemble { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}