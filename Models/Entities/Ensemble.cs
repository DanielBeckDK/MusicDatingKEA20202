using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicDating.Models.Entities 
{
    public class Ensemble 
    {
        public int EnsembleId { get; set; }
        public string EnsembleName { get; set; }
        public string EnsembleDescription { get; set; }
        public ApplicationUser AdminUser { get; set; }


        // Navigation properties
        public ICollection<GenreEnsemble> GenreEnsembles { get; set; }
        public ICollection<UserEnsemble> UserEnsembles { get; set; }
    }
}