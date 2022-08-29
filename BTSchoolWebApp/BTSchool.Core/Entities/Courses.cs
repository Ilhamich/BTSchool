using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Courses : BaseEntity
    {
        public Courses()
        {
            Groups = new HashSet<Groups>();
            ServicesOfCourses = new HashSet<ServicesOfCourses>();
            TrainersOfCourses = new HashSet<TrainersOfCourses>();
        }

        public bool? IsActive { get; set; }
        public long ProductId { get; set; }

        public virtual Products Product { get; set; }
        public virtual ICollection<Groups> Groups { get; set; }
        public virtual ICollection<ServicesOfCourses> ServicesOfCourses { get; set; }
        public virtual ICollection<TrainersOfCourses> TrainersOfCourses { get; set; }
    }
}
