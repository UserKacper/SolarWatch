using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace solarwatchAPI.DatabaseConnector;

public class UserContext : IdentityUserContext<IdentityUser>
{
    public UserContext (DbContextOptions<UserContext> options)
       : base(options)
    {
    }
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Solarwatch;User Id=postgres;Password=qwerty");
    }
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
