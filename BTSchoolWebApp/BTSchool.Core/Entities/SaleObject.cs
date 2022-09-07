using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class SaleObject : BaseEntity
    {
        public SaleObject()
        {
            Sales = new HashSet<Sale>();
        }

        public int? SotypeId { get; set; }
        public long SoentityId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual SaleObjectType Sotype { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
