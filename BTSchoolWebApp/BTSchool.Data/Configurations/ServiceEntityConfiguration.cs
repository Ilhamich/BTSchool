using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Configurations
{
    internal class ServiceEntityConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> entity) 
        {
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.Price).HasColumnType("smallmoney");
        }
    }
}
