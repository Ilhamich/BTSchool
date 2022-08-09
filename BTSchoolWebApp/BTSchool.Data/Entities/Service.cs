namespace BTSchool.Core.Entities
{
    public class Service : BaseEntity
    {
        ServiceLevel ServiceLevel { get; set; }
        int Time { get; set; }
        float Price { get; set; }
    }
}
