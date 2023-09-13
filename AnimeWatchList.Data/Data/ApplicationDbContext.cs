using AnimeWatchList.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeWatchList.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<EpisodeTracker> Episodes { get; set;}
        public DbSet<Rating> Ratings { get; set; }
    }
}