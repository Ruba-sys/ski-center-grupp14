using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class BokningConfiguration : IEntityTypeConfiguration<Bokning>
{
    public void Configure(EntityTypeBuilder<Bokning> builder)
    {
        builder.HasKey(b => b.BokningsId);

        builder.HasOne<Kund>()
            .WithMany()
            .HasForeignKey(b => b.KundId);

        builder.HasOne<Anvandare>()
            .WithMany()
            .HasForeignKey(b => b.RegistreradAv);
    }
}