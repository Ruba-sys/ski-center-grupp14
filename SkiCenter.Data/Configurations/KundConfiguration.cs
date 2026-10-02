using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class KundConfiguration : IEntityTypeConfiguration<Kund>
{
    public void Configure(EntityTypeBuilder<Kund> builder)
    {
        builder.HasKey(k => k.KundId);
    }
}