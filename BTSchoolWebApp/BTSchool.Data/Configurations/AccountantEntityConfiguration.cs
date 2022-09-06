using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class AccountantEntityConfiguration : IEntityTypeConfiguration<Accountant>
    {
        public void Configure(EntityTypeBuilder<Accountant> entity) 
        {
            entity.HasIndex(e => e.AccountId)
                  .HasName("UQ_AccountAccountants")
                  .IsUnique();

            entity.HasOne(d => d.Account)
                .WithOne(p => p.Accountants)
                .HasForeignKey<Accountant>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAccountants");
        }
    }
}
