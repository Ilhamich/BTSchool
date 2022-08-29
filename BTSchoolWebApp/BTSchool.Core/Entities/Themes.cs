using System.Collections.Generic;

namespace BTSchool.Core.Entities
{
    public partial class Themes : BaseEntity
    {
        public Themes()
        {
            Lessons = new HashSet<Lessons>();
        }

        public string Name { get; set; }

        public virtual ICollection<Lessons> Lessons { get; set; }
    }
}
