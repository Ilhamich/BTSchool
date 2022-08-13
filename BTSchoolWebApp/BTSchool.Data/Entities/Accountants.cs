namespace BTSchool.Data.Entities
{
    public partial class Accountants
    {
        public long Id { get; set; }
        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
