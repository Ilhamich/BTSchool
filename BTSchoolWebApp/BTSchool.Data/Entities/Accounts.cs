using System;

using BTSchool.Data.Entity_Enums;

namespace BTSchool.Data.Entities
{
    public partial class Accounts : BaseEntity
    {
        public UserRole? Role { get; set; } //= UserRole.NotAssigned
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }

        public virtual Accountants Accountants { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Students Students { get; set; }
        public virtual Trainers Trainers { get; set; }
    }
}
