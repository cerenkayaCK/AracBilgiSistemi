using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOrnek
{
    public class UygulamaContextDb : DbContext 
    {
        public DbSet<Araba> Arabalar { get; set; } // tablo oluşturuldu
        public DbSet<Plaka> Plakalar { get; set; }
        public DbSet<Sahip> Sahipler { get; set; }
        public DbSet<Muhendis> Muhendisler { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Online6ArabaDb;trusted_connection=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>()
                .HasMany(a => a.MuhendisListesi)
                .WithMany(m => m.Arabalar)
                .UsingEntity(j => j.ToTable("ArabaMuhendis"));
        }

    }
}
