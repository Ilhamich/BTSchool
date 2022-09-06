namespace BTSchool.Core.Entities
{
    public partial class TrainerOfGroup : BaseEntity
    {
        public long TrainerId { get; set; }
        public long GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
