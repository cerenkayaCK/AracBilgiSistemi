using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOrnek
{
    internal class UygulamaContextDb : DbContext //crud işlemleri 
    {
        public DbSet<Araba> Arabalar { get; set; } // tablo oluşturuldu
        public DbSet<Plaka> Plakalar { get; set; }

        public DbSet<Sahip> Sahipler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Online6ArabaDb;trusted_connection=true;TrustServerCertificate=True");
        }
   
    }
}
