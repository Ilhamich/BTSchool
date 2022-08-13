namespace BTSchool.Data.Entities
{
    public partial class TrainersOfGroups
    {
        public long Id { get; set; }
        public long TrainerId { get; set; }
        public long GroupId { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Trainers Trainer { get; set; }
    }
}
