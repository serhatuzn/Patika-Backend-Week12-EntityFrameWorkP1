using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=200309;Database=PatikaCodeFirstDb1");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "The Witcher 3: Wild Hunt", Platform = "PC", Rating = 9.3m },
                new Game { Id = 2, Name = "Cyberpunk 2077", Platform = "PC", Rating = 6.9m },
                new Game { Id = 3, Name = "Red Dead Redemption 2", Platform = "PC", Rating = 9.5m },
                new Game { Id = 4, Name = "Grand Theft Auto V", Platform = "PC", Rating = 9.6m },
                new Game { Id = 5, Name = "The Elder Scrolls V: Skyrim", Platform = "PC", Rating = 9.3m }
                ); // 

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994 },
                new Movie { Id = 2, Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972 },
                new Movie { Id = 3, Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 },
                new Movie { Id = 4, Title = "The Lord of the Rings: The Return of the King", Genre = "Adventure", ReleaseYear = 2003 },
                new Movie { Id = 5, Title = "Pulp Fiction", Genre = "Crime", ReleaseYear = 1994 }
                );
        }
    }
}
