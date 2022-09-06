namespace BTSchool.Core.Entities
{
    public partial class TrainerOfCourse : BaseEntity
    {
        public long TrainerId { get; set; }
        public long CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
