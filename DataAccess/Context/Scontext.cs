using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace DataAccess.Context
{
    public class Scontext : DbContext
    {

        public Scontext(DbContextOptions<Scontext> options) : base(options)
        {
        }
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();
             string connectionString = configuration.GetConnectionString("DefaultConnection");
             optionsBuilder.UseSqlServer(connectionString);
         }*/

        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Ilac> Ilaclar { get; set; }
        public DbSet<Stok> Stok { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetayları { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ilac>()
               .HasIndex(i => i.Barkod)
               .IsUnique();
            modelBuilder.Entity<Marka>()
               .HasIndex(m => m.MarkaAdi)
               .IsUnique();
            modelBuilder.Entity<Kategori>()
              .HasIndex(k => k.KategoriAdi)
              .IsUnique();
        }
    }
}