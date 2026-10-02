using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class PrisConfiguration : IEntityTypeConfiguration<Pris>
{
    public void Configure(EntityTypeBuilder<Pris> builder)
    {
        builder.HasKey(p => p.PrisId);
    }
}