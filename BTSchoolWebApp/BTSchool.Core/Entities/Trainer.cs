using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Trainer : BaseEntity
    {
        public Trainer()
        {
            Lessons = new HashSet<Lesson>();
            TrainersOfCourses = new HashSet<TrainerOfCourse>();
            TrainersOfGroups = new HashSet<TrainerOfGroup>();
        }

        public long? AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<TrainerOfCourse> TrainersOfCourses { get; set; }
        public virtual ICollection<TrainerOfGroup> TrainersOfGroups { get; set; }
    }
}
