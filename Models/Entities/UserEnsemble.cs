using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicDating.Models.Entities
{
    public class UserEnsemble
    {
        public int EnsembleId { get; set; }
        public Ensemble Ensemble { get; set; }
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}