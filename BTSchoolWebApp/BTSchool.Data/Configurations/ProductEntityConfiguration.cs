using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasIndex(e => e.Name)
                   .HasName("UQ_NameCourses")
                   .IsUnique();

            entity.Property(e => e.Brend).HasMaxLength(30);

            entity.Property(e => e.Description).HasMaxLength(30);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Price).HasColumnType("smallmoney");

            entity.Property(e => e.ProductType).HasMaxLength(30);
        }
    }
}
