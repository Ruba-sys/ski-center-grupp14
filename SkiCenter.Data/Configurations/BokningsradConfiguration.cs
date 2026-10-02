using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class BokningsradConfiguration : IEntityTypeConfiguration<Bokningsrad>
{
    public void Configure(EntityTypeBuilder<Bokningsrad> builder)
    {
        builder.HasKey(br => br.BokningsradId);

        builder.HasOne<Bokning>()
            .WithMany()
            .HasForeignKey(br => br.BokningId);
    }
}