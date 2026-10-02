using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class LoggConfiguration : IEntityTypeConfiguration<Logg>
{
    public void Configure(EntityTypeBuilder<Logg> builder)
    {
        builder.HasKey(l => l.LoggId);

        builder.HasOne<Anvandare>()
            .WithMany()
            .HasForeignKey(l => l.AnvandarId);
    }
}