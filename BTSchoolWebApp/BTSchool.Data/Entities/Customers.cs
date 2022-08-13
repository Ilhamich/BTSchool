using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Customers
    {
        public Customers()
        {
            Sales = new HashSet<Sales>();
        }

        public long Id { get; set; }
        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
