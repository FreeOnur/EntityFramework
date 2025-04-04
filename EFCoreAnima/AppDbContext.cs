using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace EFCoreAnima
{
    public class AppDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=animals.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.Property(a => a.Name).HasColumnType("TEXT");
                entity.Property(a => a.Colour).HasColumnType("TEXT");
            });
        }
    }
}
