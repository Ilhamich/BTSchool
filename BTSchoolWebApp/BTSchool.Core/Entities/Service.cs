using System;
using System.Collections.Generic;

using BTSchool.Core.Entity_Enums;

namespace BTSchool.Core.Entities
{
    public partial class Service : BaseEntity
    {
        public Service()
        {
            ServicesOfCourses = new HashSet<ServiceOfCourse>();
        }

        public string Name { get; set; }
        public ServiceLevel? ServiceLevel { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<ServiceOfCourse> ServicesOfCourses { get; set; }
    }
}
