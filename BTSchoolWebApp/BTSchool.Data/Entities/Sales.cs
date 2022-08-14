using System;

namespace BTSchool.Data.Entities
{
    public partial class Sales : BaseEntity
    {
        public DateTime Data { get; set; }
        public long CustomerId { get; set; }
        public long ProductId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}
