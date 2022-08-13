namespace BTSchool.Data.Entities
{
    public partial class StudentsOfGroups
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long StudentId { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Students Student { get; set; }
    }
}
