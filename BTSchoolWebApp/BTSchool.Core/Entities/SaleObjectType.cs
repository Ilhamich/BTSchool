using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class SaleObjectType : BaseEntity
    {
        public SaleObjectType()
        {
            SalesObject = new HashSet<SaleObject>();
        }

        public string Name { get; set; }

        public virtual ICollection<SaleObject> SalesObject { get; set; }
    }
}
