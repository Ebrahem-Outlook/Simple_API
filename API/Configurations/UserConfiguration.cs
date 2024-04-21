using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);

            builder.Property(user => user.FullName)
                .HasMaxLength(25)
                .HasColumnName("UserFullName")
                .HasDefaultValue("User")
                .IsRequired();

            builder.Property(user => user.UserName)
                .HasMaxLength(25)
                .HasColumnName("UserName")
                .IsRequired()
                .IsUnicode(true);

            builder.Property(user => user.Email)
                .HasMaxLength(25)
                .HasColumnName("UserEmail")
                .IsRequired()
                .IsUnicode(true);

            builder.Property(user => user.Password)
                .HasMaxLength(20)
                .HasDefaultValue("UserPassword")
                .IsRequired()
                .IsUnicode(true);
        }
    }
}
