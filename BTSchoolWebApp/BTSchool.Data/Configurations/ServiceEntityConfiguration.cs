using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Data.Entities;

namespace BTSchool.Data.Configurations
{
    internal class ServiceEntityConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> entity) 
        {
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.Price).HasColumnType("smallmoney");
        }
    }
}
