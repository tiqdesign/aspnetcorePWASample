using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.DataAccess.Concrete.EntityFramework
{
     public class tiqdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(@"Server=TARIKKAYA\TARIKKAYA;Database=KaramanDB; Trusted_Connection=true");
        }
        
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Proje> Proje { get; set; }
        public DbSet<IsinKonusu> IsinKonusu { get; set; }
    }
}
