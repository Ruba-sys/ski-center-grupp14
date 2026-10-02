using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class UthyrningConfiguration : IEntityTypeConfiguration<Uthyrning>
{
    public void Configure(EntityTypeBuilder<Uthyrning> builder)
    {
        builder.HasKey(u => u.UthyrningsId);

        builder.HasOne<Bokningsrad>()
            .WithMany()
            .HasForeignKey(u => u.BokningsradId);

        builder.HasOne<Utrustning>()
            .WithMany()
            .HasForeignKey(u => u.UtrustningId);
    }
}