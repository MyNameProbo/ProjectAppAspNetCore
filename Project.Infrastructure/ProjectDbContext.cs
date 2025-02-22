using Microsoft.EntityFrameworkCore;
using VueAppProjectManagement.Project.Domain;

namespace VueAppProjectManagement.Project.Infrastructure
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<ProjectTable> ProjectTables { get; set; }
        public DbSet<WorkerTable> WorkerTables { get; set; }
        public DbSet<MaterialTable> MaterialTables { get; set; }
        public DbSet<WorkingTable> WorkingTables { get; set; }
        public DbSet<WorkingLine> WorkingLines { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectTable>(entity =>
            {
                entity.HasKey(pt => pt.ProjectId);
                entity.Property(pt => pt.Name).IsRequired();

            });

            modelBuilder.Entity<WorkerTable>(entity =>
            {
                entity.HasKey(w => w.WorkerId);
                entity.Property(w => w.Name).IsRequired();
            });

            modelBuilder.Entity<MaterialTable>(entity =>
            {
                entity.HasKey(m => m.MaterialId);
                entity.Property(m => m.Description).IsRequired();
            });

            modelBuilder.Entity<WorkingTable>(entity =>
            {
                entity.HasKey(wt => wt.WorkingId);
                entity.Property(wt => wt.WorkingId).IsRequired();

                // entity.HasOne(p => p.WorkerTable)
                // .WithMany(f => f.WorkingTables)
                // .HasForeignKey(p => p.WorkerId)
                // .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<WorkingLine>(entity =>
            {
                entity.HasKey(wl => wl.LineId);

                entity.HasOne(p => p.WorkingTable)
                .WithMany(f => f.WorkingLines)
                .HasForeignKey(p => p.WorkingId)
                .OnDelete(DeleteBehavior.NoAction);

                //  entity.HasOne(p => p.MaterialTable)
                // .WithMany(f => f.WorkingLines)
                // .HasForeignKey(p => p.MaterialId)
                // .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
