namespace BTSchool.Core.Entities
{
    public partial class StudentOfGroup : BaseEntity
    {
        public long GroupId { get; set; }
        public long StudentId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Student Student { get; set; }
    }
}
