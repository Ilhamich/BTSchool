using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class TrainerEntityConfiguration : IEntityTypeConfiguration<Trainers>
    {
        public void Configure(EntityTypeBuilder<Trainers> entity) 
        {
            entity.HasIndex(e => e.AccountId)
                    .HasName("UQ_AccountTrainers")
                    .IsUnique();

            entity.HasOne(d => d.Account)
                .WithOne(p => p.Trainers)
                .HasForeignKey<Trainers>(d => d.AccountId)
                .HasConstraintName("FK_AccountTrainers");
        }
    }
}
