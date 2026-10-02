using Microsoft.EntityFrameworkCore;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Context;

public class SkiCenterDbContext : DbContext
{
    public SkiCenterDbContext(DbContextOptions<SkiCenterDbContext> options)
        : base(options)
    {
    }

    public DbSet<Kund> Kunder { get; set; }
    public DbSet<Bokning> Bokningar { get; set; }
    public DbSet<Bokningsrad> Bokningsrader { get; set; }
    public DbSet<Betalning> Betalningar { get; set; }

    public DbSet<Boende> Boenden { get; set; }
    public DbSet<Boendebokning> Boendebokningar { get; set; }

    public DbSet<Utrustning> Utrustningar { get; set; }
    public DbSet<Uthyrning> Uthyrningar { get; set; }

    public DbSet<Skidlarare> Skidlarare { get; set; }
    public DbSet<Skidskoletillfalle> Skidskoletillfallen { get; set; }
    public DbSet<Skidskolebokning> Skidskolebokningar { get; set; }

    public DbSet<Anvandare> Anvandare { get; set; }
    public DbSet<Roll> Roller { get; set; }

    public DbSet<Pris> Priser { get; set; }
    public DbSet<Logg> Loggar { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(SkiCenterDbContext).Assembly);
    }
}