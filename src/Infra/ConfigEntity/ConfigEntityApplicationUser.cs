using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.ConfigEntity
{
    public class ConfigEntityApplicationUser : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.UserName).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(100).IsRequired();
        }
    }
}
