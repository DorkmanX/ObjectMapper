using Microsoft.EntityFrameworkCore;
using ObjectsLib.Models;
using LibPull.Objects.EntityFrameworkCore;

namespace EntityFrameworkLib
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<StandConfig> StandConfigs { get; set; }
        public DbSet<StandConfig> PullOrder { get; set; }
        public DbSet<StandConfig> WorkOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StandConfig>()
                .ToTable(nameof(StandConfig));

            modelBuilder.Entity<PullOrder>()
                .ToTable(nameof(PullOrder));

            modelBuilder.Entity<WorkOrder>()
                .ToTable(nameof(WorkOrder));

        }
    }
}
