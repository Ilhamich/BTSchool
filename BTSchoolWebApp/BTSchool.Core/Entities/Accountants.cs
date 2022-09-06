namespace BTSchool.Core.Entities
{
    public partial class Accountant : BaseEntity
    {
        public long AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
