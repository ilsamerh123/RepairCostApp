using Microsoft.EntityFrameworkCore;
using RepairCostApp.Entities;

namespace RepairCostApp.Data 
{
    public class DataContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<CostArticle> CostArticles { get; set; }
        public DbSet<RepairWork> RepairWorks { get; set; }
        public DbSet<Estimate> Estimates { get; set; }
        public DbSet<EstimateItem> EstimateItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=repair_cost_db;Username=postgres;Password=ilsiyar26;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estimate>()
                .HasMany(e => e.Items)
                .WithOne()
                .HasForeignKey(i => i.EstimateId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RepairWork>()
                .HasOne<Room>()
                .WithMany()
                .HasForeignKey(w => w.RoomId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<RepairWork>()
                .HasOne<Contractor>()
                .WithMany()
                .HasForeignKey(w => w.ContractorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RepairWork>()
                .HasOne<CostArticle>()
                .WithMany()
                .HasForeignKey(w => w.CostArticleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Estimate>()
                .HasOne<Room>()
                .WithMany()
                .HasForeignKey(e => e.RoomId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}