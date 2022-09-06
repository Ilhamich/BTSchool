namespace BTSchool.Core.Entities
{
    public partial class ServiceOfCourse : BaseEntity
    {
        public long CourseId { get; set; }
        public long ServiceId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Service Service { get; set; }
    }
}
