namespace BTSchool.Data.Entities
{
    public partial class Accountants : BaseEntity
    {
        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
