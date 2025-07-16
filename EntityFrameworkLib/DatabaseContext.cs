using Microsoft.EntityFrameworkCore;
using ObjectsLib.Models;

namespace EntityFrameworkLib
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<StandConfig> StandConfigs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>()
                .ToTable(nameof(Users));

            modelBuilder.Entity<StandConfig>()
                .ToTable(nameof(StandConfig));

        }
    }
}
