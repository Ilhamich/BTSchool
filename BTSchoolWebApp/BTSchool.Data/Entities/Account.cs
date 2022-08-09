using System;

namespace BTSchool.Core.Entities
{
    public class Account : BaseEntity
    {
        UserRole Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
    }
}
