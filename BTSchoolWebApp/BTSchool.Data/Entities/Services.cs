using System;
using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Services
    {
        public Services()
        {
            ServicesOfCourses = new HashSet<ServicesOfCourses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public byte? ServiceLevel { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<ServicesOfCourses> ServicesOfCourses { get; set; }
    }
}
