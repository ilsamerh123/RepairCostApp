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

            // Настройка связи многие-ко-многим для Сметы и Элементов сметы
            modelBuilder.Entity<Estimate>()
                .HasMany(e => e.Items)
                .WithOne()
                .HasForeignKey(i => i.EstimateId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}