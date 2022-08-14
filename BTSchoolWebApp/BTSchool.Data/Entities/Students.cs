using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Students : BaseEntity
    {
        public Students()
        {
            StudentsOfGroups = new HashSet<StudentsOfGroups>();
        }

        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<StudentsOfGroups> StudentsOfGroups { get; set; }
    }
}
