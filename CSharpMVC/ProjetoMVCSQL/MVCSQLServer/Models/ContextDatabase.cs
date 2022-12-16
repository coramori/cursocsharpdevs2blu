using Microsoft.EntityFrameworkCore;
using MVCSQLServer.Models.Entities;

namespace MVCSQLServer.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Game>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Games)
                .HasForeignKey(p => p.CategoryId);

            // Seed
            modelBuilder.Entity<Category>()
                .HasData(
                new { Id = 1, Name = "MMORPG" },
                new { Id = 2, Name = "First Person Shooter" },
                new { Id = 3, Name = "Simulation" },
                new { Id = 4, Name = "Moba" }
                );

            modelBuilder.Entity<Game>()
                .HasData(
                new { Id = 1, Name = "World of Warcraft", CategoryId = 1 },
                new { Id = 2, Name = "Final Fantasy XIV", CategoryId = 1 },
                new { Id = 3, Name = "CS:GO", CategoryId = 2 },
                new { Id = 4, Name = "Overwatch", CategoryId = 2 },
                new { Id = 5, Name = "The Sims 4", CategoryId = 3 },
                new { Id = 6, Name = "Stardew Valley", CategoryId = 3 },
                new { Id = 7, Name = "League of Legends", CategoryId = 4 },
                new { Id = 8, Name = "Dota 2", CategoryId = 4 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Category> Category { get; set; }
        public DbSet<Game> Game { get; set; }

        #endregion
    }
}
