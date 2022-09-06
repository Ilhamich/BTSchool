using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Student : BaseEntity
    {
        public Student()
        {
            StudentsOfGroups = new HashSet<StudentOfGroup>();
        }

        public long AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<StudentOfGroup> StudentsOfGroups { get; set; }
    }
}
