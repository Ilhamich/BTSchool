using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    class AccountEntityConfiguration : IEntityTypeConfiguration<Account> 
    {
        public void Configure(EntityTypeBuilder<Account> entity) 
        {
            entity.HasIndex(e => e.Email)
                   .HasName("UQ_EmailAccounts")
                   .IsUnique();

            entity.Property(e => e.Birthday)
                .HasColumnType("date");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(80);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
        }
    }
}
