using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            entity.HasIndex(e => e.AccountId)
                    .HasName("UQ_AccountStudents")
                    .IsUnique();

            entity.HasOne(d => d.Account)
                .WithOne(p => p.Students)
                .HasForeignKey<Student>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountStudents");
        }
    }
}
