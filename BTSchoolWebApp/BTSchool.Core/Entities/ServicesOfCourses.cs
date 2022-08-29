namespace BTSchool.Core.Entities
{
    public partial class ServicesOfCourses : BaseEntity
    {
        public long CourseId { get; set; }
        public long ServiceId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Services Service { get; set; }
    }
}
