using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Product : BaseEntity
    {
        public Product()
        {
            Courses = new HashSet<Course>();
            Sales = new HashSet<Sale>();
        }

        public string ProductType { get; set; }
        public string Brend { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
