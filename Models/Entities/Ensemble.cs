using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicDating.Models.Entities 
{
    public class Ensemble 
    {
        [Key]
        public int EnsembleId { get; set; }
        public string EnsembleName { get; set; }
        public string EnsembleDescription { get; set; }
        public string Id { get; set; }

        // Navigation properties
        public ICollection<GenreEnsemble> GenreEnsembles { get; set; }
        public ICollection<UserEnsemble> UserEnsembles { get; set; }
        [ForeignKey("Id")]
        public ApplicationUser AdminUser { get; set; }
    }
}