using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class SaleEntityConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> entity) 
        {
            entity.Property(e => e.Data).HasColumnType("smalldatetime");

            entity.Property(e => e.SoId).HasColumnName("SO_Id");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.Sales)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_Customer_Id");

            entity.HasOne(d => d.So)
                .WithMany(p => p.Sales)
                .HasForeignKey(d => d.SoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sale_SO_Id");
        }
    }
}
