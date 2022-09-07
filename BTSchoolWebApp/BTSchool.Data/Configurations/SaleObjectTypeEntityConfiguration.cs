using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class SaleObjectTypeEntityConfiguration : IEntityTypeConfiguration<SaleObjectType>
    {
        public void Configure(EntityTypeBuilder<SaleObjectType> entity) 
        {
            entity.HasIndex(e => e.Name)
                .HasName("UQ_Name_Of_SalesObject_Type")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
