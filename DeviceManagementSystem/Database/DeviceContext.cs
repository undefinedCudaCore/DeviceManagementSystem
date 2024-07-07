using DeviceManagementSystem.Database.InitialData;
using DeviceManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagementSystem.Database
{
    public class DeviceContext : DbContext
    {
        public DeviceContext()
        {
            ConnectionString = "Data Source=TEKLIANLI\\SQLEXPRESS;Initial Catalog=DeviceManagementSystemDB;" +
                "Integrated Security=True;Encrypt=False";
        }

        internal DbSet<Device> Devices { get; set; }

        public string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(d => d.DeviceId);

                entity.Property(d => d.DeviceId)
                .HasColumnOrder(1);
                entity.Property(d => d.Model)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnOrder(2);
                entity.Property(d => d.Manufacturer)
                    .HasMaxLength(150)
                    .HasColumnOrder(3);
                entity.Property(s => s.ManufactureDate)
                    .IsRequired()
                    .HasColumnOrder(4)
                    .HasColumnType("datetime");
                entity.Property(s => s.Date)
                    .HasColumnType("datetime");
                entity.Property(d => d.SerialNumber)
                    .HasMaxLength(11)
                    .HasColumnOrder(5);
            });

            modelBuilder.Entity<Device>().HasData(DeviceData.DataSeed);
        }
    }
}
