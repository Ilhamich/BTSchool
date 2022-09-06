using System;

namespace BTSchool.Core.Entities
{
    public partial class Lesson : BaseEntity
    {
        public long TrainerId { get; set; }
        public long GroupId { get; set; }
        public long ThemeId { get; set; }
        public DateTime LessonDate { get; set; }

        public virtual Group Group { get; set; }
        public virtual Theme Theme { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
