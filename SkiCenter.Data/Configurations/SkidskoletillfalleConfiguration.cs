using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class SkidskoletillfalleConfiguration : IEntityTypeConfiguration<Skidskoletillfalle>
{
    public void Configure(EntityTypeBuilder<Skidskoletillfalle> builder)
    {
        builder.HasKey(s => s.TillfalleId);

        builder.HasOne<Skidlarare>()
            .WithMany()
            .HasForeignKey(s => s.LarareId);
    }
}