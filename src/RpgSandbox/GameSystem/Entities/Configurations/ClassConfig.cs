using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RpgSandbox.GameSystem.Entities.Configurations;

public class ClassConfig : IEntityTypeConfiguration<Class>
{
    public void Configure(EntityTypeBuilder<Class> builder)
    {
        builder.Property(c => c.Name).IsRequired();
        builder.Property(c => c.Description).IsRequired();
        builder.Property(c => c.ImageUrl).IsRequired();
        
        builder.HasMany(p => p.PartyRoles).WithMany(p => p.Classes);
    }
}