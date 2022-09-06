using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Customer : BaseEntity
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public long AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
