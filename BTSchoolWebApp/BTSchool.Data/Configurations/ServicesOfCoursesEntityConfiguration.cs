using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class ServicesOfCoursesEntityConfiguration : IEntityTypeConfiguration<ServiceOfCourse>
    {
        public void Configure(EntityTypeBuilder<ServiceOfCourse> entity) 
        {
            entity.HasIndex(e => new { e.CourseId, e.ServiceId })
                    .HasName("UQ_MasterAndService")
                    .IsUnique();

            entity.HasOne(d => d.Course)
                .WithMany(p => p.ServicesOfCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseOfServices");

            entity.HasOne(d => d.Service)
                .WithMany(p => p.ServicesOfCourses)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceOfCourses");
        }
    }
}
