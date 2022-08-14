using System;

namespace BTSchool.Data.Entities
{
    public partial class Lessons : BaseEntity
    {
        public long TrainerId { get; set; }
        public long GroupId { get; set; }
        public long ThemeId { get; set; }
        public DateTime LessonDate { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Themes Theme { get; set; }
        public virtual Trainers Trainer { get; set; }
    }
}
