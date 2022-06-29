using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RpgSandbox.Auth.Entities.Configurations;

public class UserConfig: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Email).IsRequired();
        builder.Property(u => u.ScreenName).IsRequired();
        builder.Property(u => u.PassHash).IsRequired();
    }
}