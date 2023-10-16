using Microsoft.EntityFrameworkCore;
namespace Unit2Project.Models
{
    public class AnimeContext : DbContext
    {
        public AnimeContext(DbContextOptions<AnimeContext> options)
        : base(options) { }

        public DbSet<AnimeContext> Anime { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anime>().HasData(

                new Anime
                {
                    AnimeId = 1,
                    AnimeName = "One Piece", 
                    Rating = null,
                },
                new Anime
                {
                    AnimeId = 2,
                    AnimeName = "Naruto",
                    Rating = null,
                },
                new Anime
                {
                    AnimeId = 3,
                    AnimeName = "Bleach",
                    Rating = null,
                }
            );

        }
    }
}