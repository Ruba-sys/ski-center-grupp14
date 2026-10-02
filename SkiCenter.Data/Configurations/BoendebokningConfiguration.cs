using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class BoendebokningConfiguration : IEntityTypeConfiguration<Boendebokning>
{
    public void Configure(EntityTypeBuilder<Boendebokning> builder)
    {
        builder.HasKey(bb => bb.BoendebokningId);

        builder.HasOne<Bokningsrad>()
            .WithMany()
            .HasForeignKey(bb => bb.BokningsradId);

        builder.HasOne<Boende>()
            .WithMany()
            .HasForeignKey(bb => bb.BoendeId);
    }
}