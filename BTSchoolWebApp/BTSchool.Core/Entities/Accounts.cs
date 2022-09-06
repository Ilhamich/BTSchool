using System;

using BTSchool.Core.Entity_Enums;

namespace BTSchool.Core.Entities
{
    public partial class Account : BaseEntity
    {
        public UserRole? Role { get; set; } //= UserRole.NotAssigned
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }

        public virtual Accountant Accountants { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual Student Students { get; set; }
        public virtual Trainer Trainers { get; set; }
    }
}
