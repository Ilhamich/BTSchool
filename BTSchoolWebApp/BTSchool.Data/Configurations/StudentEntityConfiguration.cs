using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class StudentEntityConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> entity)
        {
            entity.HasIndex(e => e.AccountId)
                    .HasName("UQ_AccountStudents")
                    .IsUnique();

            entity.HasOne(d => d.Account)
                .WithOne(p => p.Students)
                .HasForeignKey<Students>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountStudents");
        }
    }
}
