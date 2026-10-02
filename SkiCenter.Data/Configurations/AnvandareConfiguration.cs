using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class AnvandareConfiguration : IEntityTypeConfiguration<Anvandare>
{
    public void Configure(EntityTypeBuilder<Anvandare> builder)
    {
        builder.HasKey(a => a.AnvandarId);

        builder.HasOne<Roll>()
            .WithMany()
            .HasForeignKey(a => a.RollId);
    }
}