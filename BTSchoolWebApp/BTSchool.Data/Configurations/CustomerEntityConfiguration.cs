using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class CustomerEntityConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> entity)
        {
            entity.HasIndex(e => e.AccountId)
                    .HasName("UQ_AccountCustomers")
                    .IsUnique();

            entity.HasOne(d => d.Account)
                .WithOne(p => p.Customers)
                .HasForeignKey<Customers>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountCustomers");
        }
    }
}
