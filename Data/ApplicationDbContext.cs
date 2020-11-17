using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicDating.Models.Entities;

namespace MusicDating.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser> {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<GenreEnsemble>()
        .HasKey(bc => new { bc.GenreId, bc.EnsembleId });  
        modelBuilder.Entity<GenreEnsemble>()
        .HasOne(bc => bc.Genre)
        .WithMany(b => b.GenreEnsembles)
        .HasForeignKey(bc => bc.GenreId);  
        modelBuilder.Entity<GenreEnsemble>()
        .HasOne(bc => bc.Ensemble)
        .WithMany(c => c.GenreEnsembles)
        .HasForeignKey(bc => bc.EnsembleId);

        modelBuilder.Entity<UserInstrument>()
        .HasKey(bc => new { bc.Id, bc.InstrumentId });  
        modelBuilder.Entity<UserInstrument>()
        .HasOne(bc => bc.ApplicationUser)
        .WithMany(b => b.UserInstruments)
        .HasForeignKey(bc => bc.Id);  
        modelBuilder.Entity<UserInstrument>()
        .HasOne(bc => bc.Instrument)
        .WithMany(c => c.UserInstruments)
        .HasForeignKey(bc => bc.InstrumentId);

        modelBuilder.Entity<UserEnsemble>()
        .HasKey(bc => new { bc.Id, bc.EnsembleId });  
        modelBuilder.Entity<UserEnsemble>()
        .HasOne(bc => bc.ApplicationUser)
        .WithMany(b => b.UserEnsembles)
        .HasForeignKey(bc => bc.Id);  
        modelBuilder.Entity<UserEnsemble>()
        .HasOne(bc => bc.Ensemble)
        .WithMany(c => c.UserEnsembles)
        .HasForeignKey(bc => bc.EnsembleId);

        modelBuilder.Entity<Genre>().HasData(
            new Genre {GenreId = 1,GenreName = "Metal"},
            new Genre {GenreId = 2, GenreName = "Rock"}      
            );

        modelBuilder.Entity<Ensemble>().HasData(
            new Ensemble { EnsembleId = 1, EnsembleName = "TV2", EnsembleDescription = " Vi er TV2 og vi laver dårlig musik"},
            new Ensemble {EnsembleId = 2, EnsembleName = "DR1", EnsembleDescription = "Vi er DR1 og vi æder licens penge til frokost"}
            );

        modelBuilder.Entity<GenreEnsemble>().HasData(
            new GenreEnsemble {GenreId = 1,EnsembleId = 1},
            new GenreEnsemble {GenreId = 2,EnsembleId = 2}
            );

        modelBuilder.Entity<UserEnsemble>().HasData(
            new UserEnsemble {Id = "1",EnsembleId = 1},
            new UserEnsemble {Id = "2",EnsembleId = 2}
            );

        modelBuilder.Entity<Instrument>().HasData(
            new Instrument {InstrumentId = 1,Name = "Trumpet"},
            new Instrument {InstrumentId = 2,Name = "Piano"} 
            );

        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser {FirstName = "Søren",LastName = "Rembøll", Id="1",Email="soren.remboll@gmail.com", UserName="soren.remboll@gmail.com"},
            new ApplicationUser {FirstName = "Daniel",LastName = "Beck",Id="2"},
            new ApplicationUser {FirstName = "Christian",LastName = "Kirschberg",Id="3"}                
            );

        modelBuilder.Entity<UserInstrument>().HasData(
            new UserInstrument { Id="1", InstrumentId = 2, Level = 5},
            new UserInstrument { Id="2", InstrumentId = 2, Level = 3},
            new UserInstrument { Id="3", InstrumentId = 1, Level = 1}
            );
            

    }

        // This means that EF (Entity Framework) will create a table called Instrument based
        // on our Instrument class.
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Ensemble> Ensembles { get; set; }
        public DbSet<MusicDating.Models.Entities.Agent> Agent { get; set; }
        public DbSet<UserInstrument> UserInstrument { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<UserEnsemble> UserEnsemble { get; set; }


        // This means that EF (Entity Framework) will create a table called Instrument based
        // on our Instrument class.
        
    }
    
}
