using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkiCenter.Business.Models;

namespace SkiCenter.Data.Configurations;

public class UtrustningConfiguration : IEntityTypeConfiguration<Utrustning>
{
    public void Configure(EntityTypeBuilder<Utrustning> builder)
    {
        builder.HasKey(u => u.UtrustningsId);
    }
}