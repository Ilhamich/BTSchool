namespace BTSchool.Data.Entities
{
    public partial class TrainersOfCourses
    {
        public long Id { get; set; }
        public long TrainerId { get; set; }
        public long CourseId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Trainers Trainer { get; set; }
    }
}
