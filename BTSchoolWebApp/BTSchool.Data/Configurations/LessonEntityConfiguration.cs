using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class LessonEntityConfiguration : IEntityTypeConfiguration<Lessons>
    {
        public void Configure(EntityTypeBuilder<Lessons> entity) 
        {
            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.LessonDate).HasColumnType("datetime");

            entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

            entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.Lessons)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupLessons");

            entity.HasOne(d => d.Theme)
                .WithMany(p => p.Lessons)
                .HasForeignKey(d => d.ThemeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThemeLessons");

            entity.HasOne(d => d.Trainer)
                .WithMany(p => p.Lessons)
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainerLessons");
        }
    }
}
