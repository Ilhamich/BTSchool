using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class StudentsOfGroupsEntityConfiguration : IEntityTypeConfiguration<StudentsOfGroups>
    {
        public void Configure(EntityTypeBuilder<StudentsOfGroups> entity) 
        {
            entity.HasIndex(e => new { e.StudentId, e.GroupId })
                    .HasName("UQ_StudentAndGroup")
                    .IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.StudentsOfGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupOfStudents");

            entity.HasOne(d => d.Student)
                .WithMany(p => p.StudentsOfGroups)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentOfGroups");
        }
    }
}
