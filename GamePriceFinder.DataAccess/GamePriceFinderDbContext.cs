using GamePriceFinder.DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamePriceFinder.DataAccess
{
    public class GamePriceFinderDbContext : DbContext
    {
        public GamePriceFinderDbContext(DbContextOptions<GamePriceFinderDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Game>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Game>()
                .HasIndex(x => x.ExternalId).IsUnique();
            modelBuilder.Entity<Game>()
                .HasMany(g => g.Reviews)
                .WithOne(r => r.Game)
                .HasForeignKey(r => r.GameId);
            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<User>()
                .HasIndex(x => x.ExternalId).IsUnique();
            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);
            modelBuilder.Entity<Review>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Review>()
                .HasIndex(x => x.ExternalId);
        }


        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }

}
