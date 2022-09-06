using System;

namespace BTSchool.Core.Entities
{
    public partial class Sale : BaseEntity
    {
        public DateTime Data { get; set; }
        public long CustomerId { get; set; }
        public long ProductId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
