namespace BTSchool.Data.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public long Id { get; set; }
    }

    public interface IBaseEntity
    {
        public long Id { get; set; }
    }
}
