using System.Reflection;
using Microsoft.EntityFrameworkCore;
using RpgSandbox.Auth.Entities;
using RpgSandbox.GameSystem.Entities;
using RpgSandbox.PlayerArea.Entities;

namespace RpgSandbox.Common;

public class RpgDataContext : DbContext
{
    public RpgDataContext(DbContextOptions options) : base(options)
    {
        
    }
    
    // protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    // {
    //     configurationBuilder.Properties<string>().HaveMaxLength(150);
    //     base.ConfigureConventions(configurationBuilder);
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        GameSystem.Entities.Seeding.InitialSetupSeed.Seed(modelBuilder);
        PlayerArea.Entities.Seeding.HeroSeed.Seed(modelBuilder);
    }
    
    public DbSet<Class> Classes { get; set; }
    public DbSet<Ability> Abilities { get; set; }
    public DbSet<PartyRole> PartyRoles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Hero> Heroes { get; set; }
}