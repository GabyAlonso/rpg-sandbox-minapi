using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RpgSandbox.PlayerArea.Entities.Configurations;

public class HeroConfig: IEntityTypeConfiguration<Hero>
{
    public void Configure(EntityTypeBuilder<Hero> builder)
    {
        builder.Property(c => c.Name).IsRequired();
        builder.Property(c => c.ImageUrl).IsRequired();
    }
}