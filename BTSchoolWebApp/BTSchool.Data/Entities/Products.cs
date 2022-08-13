using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Products
    {
        public Products()
        {
            Courses = new HashSet<Courses>();
            Sales = new HashSet<Sales>();
        }

        public long Id { get; set; }
        public string ProductType { get; set; }
        public string Brend { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
