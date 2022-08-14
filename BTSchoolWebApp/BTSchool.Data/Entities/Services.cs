using System;
using System.Collections.Generic;

using BTSchool.Data.Entity_Enums;

namespace BTSchool.Data.Entities
{
    public partial class Services : BaseEntity
    {
        public Services()
        {
            ServicesOfCourses = new HashSet<ServicesOfCourses>();
        }

        public string Name { get; set; }
        public ServiceLevel? ServiceLevel { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<ServicesOfCourses> ServicesOfCourses { get; set; }
    }
}
