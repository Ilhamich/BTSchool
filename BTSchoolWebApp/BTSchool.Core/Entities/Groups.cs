using System;
using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Group : BaseEntity
    {
        public Group()
        {
            Lessons = new HashSet<Lesson>();
            StudentsOfGroups = new HashSet<StudentOfGroup>();
            TrainersOfGroups = new HashSet<TrainerOfGroup>();
        }

        public long CourseId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<StudentOfGroup> StudentsOfGroups { get; set; }
        public virtual ICollection<TrainerOfGroup> TrainersOfGroups { get; set; }
    }
}
