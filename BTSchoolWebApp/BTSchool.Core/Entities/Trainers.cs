using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Trainers : BaseEntity
    {
        public Trainers()
        {
            Lessons = new HashSet<Lessons>();
            TrainersOfCourses = new HashSet<TrainersOfCourses>();
            TrainersOfGroups = new HashSet<TrainersOfGroups>();
        }

        public long? AccountId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<Lessons> Lessons { get; set; }
        public virtual ICollection<TrainersOfCourses> TrainersOfCourses { get; set; }
        public virtual ICollection<TrainersOfGroups> TrainersOfGroups { get; set; }
    }
}
