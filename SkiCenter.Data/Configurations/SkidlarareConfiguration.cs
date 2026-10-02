using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class SkidlarareConfiguration : IEntityTypeConfiguration<Skidlarare>
{
    public void Configure(EntityTypeBuilder<Skidlarare> builder)
    {
        builder.HasKey(s => s.LarareId);
    }
}