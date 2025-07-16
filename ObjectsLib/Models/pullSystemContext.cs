using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class PullSystemContext : DbContext
    {
        public string _connectionString { get; internal set; }

        public PullSystemContext(DbContextOptions<PullSystemContext> options)
            : base(options)
        {
        }

        public PullSystemContext(string connectionString)
            : base(CreateOptions(connectionString))
        {
            _connectionString = connectionString;
        }

        private static DbContextOptions<PullSystemContext> CreateOptions(string connString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PullSystemContext>();
            optionsBuilder.UseSqlServer(connString);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            return optionsBuilder.Options;
        }

        // ------------------
        // usuń lub zakomentuj te trzy linie:
        // public virtual DbQuery<WorkOrderFromView> vWorkOrders { get; set; }
        // public virtual DbQuery<BomHpFromView> vBomHP { get; set; }
        // public virtual DbQuery<BufferHpView> vBuffersHP { get; set; }
        // ------------------

        public virtual DbSet<BufferHP> BufferHP { get; set; }
        public virtual DbSet<ClientPdm> ClientPdm { get; set; }
        // … wszystkie pozostałe DbSetów aż do …
        public virtual DbSet<StandConfig> StandConfig { get; set; }
        // … i niżej DbSets …

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            // ---------- usuń całą sekcję mapowania widoków: -------------
            // modelBuilder.Query<WorkOrderFromView>(entity =>
            // {
            //     entity.ToView("v_WorkOrders");
            // });
            // modelBuilder.Query<BomHpFromView>(entity =>
            // {
            //     entity.ToView("v_BomHP");
            // });
            // modelBuilder.Query<BufferHpView>(entity =>
            // {
            //     entity.ToView("v_BuffersHP");
            // });
            // ------------------------------------------------------------

            // dalej wszystkie dotychczasowe konfiguracje entity…
            modelBuilder.Entity<ClientPdm>(entity =>
            {
                entity.ToTable("ClientPDM");
                entity.Property(e => e.Id).HasColumnName("ID");
                // …
            });

            modelBuilder.Entity<BufferHP>(entity =>
            {
                // …
            });

            // …
            modelBuilder.Entity<StandConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                // …
            });

            // (reszta konfiguracji bez zmian)
        }
    }
}
