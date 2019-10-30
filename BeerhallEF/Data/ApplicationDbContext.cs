using BeerhallEF.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace BeerhallEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "Server=localhost;DataBase=Linq2C1;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
        }
    }
}
