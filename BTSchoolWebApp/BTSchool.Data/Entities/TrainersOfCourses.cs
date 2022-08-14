namespace BTSchool.Data.Entities
{
    public partial class TrainersOfCourses : BaseEntity
    {
        public long TrainerId { get; set; }
        public long CourseId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Trainers Trainer { get; set; }
    }
}
