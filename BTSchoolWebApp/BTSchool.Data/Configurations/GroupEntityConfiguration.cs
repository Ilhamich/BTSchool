using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class GroupEntityConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> entity)
        {
            entity.HasIndex(e => e.Name)
                    .HasName("UQ_NameGroups")
                    .IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.FinishDate).HasColumnType("date");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.Course)
                .WithMany(p => p.Groups)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseGroups");
        }
    }
}
