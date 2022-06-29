using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RpgSandbox.GameSystem.Entities.Configurations;

public class AbilityConfig : IEntityTypeConfiguration<Ability>
{
    public void Configure(EntityTypeBuilder<Ability> builder)
    {
        builder.Property(c => c.Name).IsRequired();
        builder.Property(c => c.Description).IsRequired();
    }
}