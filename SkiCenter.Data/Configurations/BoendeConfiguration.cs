using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class BoendeConfiguration : IEntityTypeConfiguration<Boende>
{
    public void Configure(EntityTypeBuilder<Boende> builder)
    {
        builder.HasKey(b => b.BoendeId);
    }
}