using System;
using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Groups : BaseEntity
    {
        public Groups()
        {
            Lessons = new HashSet<Lessons>();
            StudentsOfGroups = new HashSet<StudentsOfGroups>();
            TrainersOfGroups = new HashSet<TrainersOfGroups>();
        }

        public long CourseId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

        public virtual Courses Course { get; set; }
        public virtual ICollection<Lessons> Lessons { get; set; }
        public virtual ICollection<StudentsOfGroups> StudentsOfGroups { get; set; }
        public virtual ICollection<TrainersOfGroups> TrainersOfGroups { get; set; }
    }
}
