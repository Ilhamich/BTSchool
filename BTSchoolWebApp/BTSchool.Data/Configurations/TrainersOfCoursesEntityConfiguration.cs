using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class TrainersOfCoursesEntityConfiguration : IEntityTypeConfiguration<TrainersOfCourses>
    {
        public void Configure(EntityTypeBuilder<TrainersOfCourses> entity) 
        {
            entity.HasIndex(e => new { e.TrainerId, e.CourseId })
                   .HasName("UQ_TrainerAndCourse")
                   .IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

            entity.HasOne(d => d.Course)
                .WithMany(p => p.TrainersOfCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseOfTrainers");

            entity.HasOne(d => d.Trainer)
                .WithMany(p => p.TrainersOfCourses)
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainerOfCourses");
        }
    }
}
