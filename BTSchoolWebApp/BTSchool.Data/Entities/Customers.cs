using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Customers : BaseEntity
    {
        public Customers()
        {
            Sales = new HashSet<Sales>();
        }

        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
