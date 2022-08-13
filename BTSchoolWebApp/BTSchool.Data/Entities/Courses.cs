using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Courses
    {
        public Courses()
        {
            Groups = new HashSet<Groups>();
            ServicesOfCourses = new HashSet<ServicesOfCourses>();
            TrainersOfCourses = new HashSet<TrainersOfCourses>();
        }

        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public long ProductId { get; set; }

        public virtual Products Product { get; set; }
        public virtual ICollection<Groups> Groups { get; set; }
        public virtual ICollection<ServicesOfCourses> ServicesOfCourses { get; set; }
        public virtual ICollection<TrainersOfCourses> TrainersOfCourses { get; set; }
    }
}
