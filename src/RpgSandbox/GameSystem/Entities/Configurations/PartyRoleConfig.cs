using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RpgSandbox.GameSystem.Entities.Configurations;

public class PartyRoleConfig: IEntityTypeConfiguration<PartyRole>
{
    public void Configure(EntityTypeBuilder<PartyRole> builder)
    {
        builder.Property(c => c.Name).IsRequired();
    }
}