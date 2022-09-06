using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class TrainersOfGroupsEntityConfiguration : IEntityTypeConfiguration<TrainerOfGroup>
    {
        public void Configure(EntityTypeBuilder<TrainerOfGroup> entity) 
        {
            entity.HasIndex(e => new { e.TrainerId, e.GroupId })
                    .HasName("UQ_TrainerAndGroup")
                    .IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.TrainersOfGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentGroupOfMentors");

            entity.HasOne(d => d.Trainer)
                .WithMany(p => p.TrainersOfGroups)
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainerOfGroups");
        }
    }
}
