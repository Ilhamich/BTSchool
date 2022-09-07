using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Course : BaseEntity
    {
        public Course()
        {
            Groups = new HashSet<Group>();
            ServicesOfCourses = new HashSet<ServiceOfCourse>();
            TrainersOfCourses = new HashSet<TrainerOfCourse>();
        }

        public bool? IsActive { get; set; }
        public bool? IsIndividual { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<ServiceOfCourse> ServicesOfCourses { get; set; }
        public virtual ICollection<TrainerOfCourse> TrainersOfCourses { get; set; }
    }
}
