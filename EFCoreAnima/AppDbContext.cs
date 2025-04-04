using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAnima.Classes;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAnima
{
    public class AppDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Tierheim> Tierheime { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=animals.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguration der Beziehung (sofern vorhanden)
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Tierheim)
                .WithMany(t => t.AnimalsList)
                .HasForeignKey(a => a.TierheimId);
        }
    }
}