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

        public ServiceLevel? ServiceLevel { get; set; }
        public TimeSpan? Time { get; set; }

        public virtual ICollection<ServiceOfCourse> ServicesOfCourses { get; set; }
    }
}
