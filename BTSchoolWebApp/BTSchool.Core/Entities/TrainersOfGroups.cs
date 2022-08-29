namespace BTSchool.Core.Entities
{
    public partial class TrainersOfGroups : BaseEntity
    {
        public long TrainerId { get; set; }
        public long GroupId { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Trainers Trainer { get; set; }
    }
}
