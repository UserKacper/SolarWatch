using Microsoft.EntityFrameworkCore;
using solarwatchAPI.Models;

namespace solarwatchAPI.DatabaseConnector
{
    public class CityContext : DbContext
    {
        public DbSet<City> cities { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Solarwatch;User Id=postgres;Password=qwerty");
        }
    }
}
