using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class SkidskolebokningConfiguration : IEntityTypeConfiguration<Skidskolebokning>
{
    public void Configure(EntityTypeBuilder<Skidskolebokning> builder)
    {
        builder.HasKey(sb => sb.SkidskolebokningId);

        builder.HasOne<Bokningsrad>()
            .WithMany()
            .HasForeignKey(sb => sb.BokningsradId);

        builder.HasOne<Skidskoletillfalle>()
            .WithMany()
            .HasForeignKey(sb => sb.TillfalleId);
    }
}