using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class SaleObjectEntityConfiguration : IEntityTypeConfiguration<SaleObject>
    {
        public void Configure(EntityTypeBuilder<SaleObject> entity)
        {
            entity.HasIndex(e => e.Name)
                .HasName("UQ_NameSO")
                .IsUnique();

            entity.HasIndex(e => new { e.SotypeId, e.SoentityId })
                .HasName("UQ_Entity_Id_SO_Type_Id")
                .IsUnique();

            entity.Property(e => e.Description).HasMaxLength(30);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Price).HasColumnType("smallmoney");

            entity.Property(e => e.SoentityId).HasColumnName("SOEntityId");

            entity.Property(e => e.SotypeId).HasColumnName("SOTypeId");

            entity.HasOne(d => d.Sotype)
                .WithMany(p => p.SalesObject)
                .HasForeignKey(d => d.SotypeId)
                .HasConstraintName("FK_SO_Type");
        }
    }
}
