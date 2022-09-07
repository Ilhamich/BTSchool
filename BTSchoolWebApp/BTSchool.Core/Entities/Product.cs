using System;

namespace BTSchool.Core.Entities
{
    public partial class Product : BaseEntity
    {
        public string Brend { get; set; }
        public bool? HasExpirationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
