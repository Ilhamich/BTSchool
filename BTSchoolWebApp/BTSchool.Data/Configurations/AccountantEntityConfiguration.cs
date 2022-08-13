using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class AccountantEntityConfiguration : IEntityTypeConfiguration<Accountants>
    {
        public void Configure(EntityTypeBuilder<Accountants> entity) 
        {
            entity.HasIndex(e => e.AccountId)
                  .HasName("UQ_AccountAccountants")
                  .IsUnique();

            entity.HasOne(d => d.Account)
                .WithOne(p => p.Accountants)
                .HasForeignKey<Accountants>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAccountants");
        }
    }
}
