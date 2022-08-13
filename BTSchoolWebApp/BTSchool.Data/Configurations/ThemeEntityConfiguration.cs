using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class ThemeEntityConfiguration : IEntityTypeConfiguration<Themes>
    {
        public void Configure(EntityTypeBuilder<Themes> entity) 
        {
            entity.HasIndex(e => e.Name)
                  .HasName("UQ_NameThemes")
                  .IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
