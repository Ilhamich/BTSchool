using System.Collections.Generic;

namespace BTSchool.Data.Entities
{
    public partial class Themes
    {
        public Themes()
        {
            Lessons = new HashSet<Lessons>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lessons> Lessons { get; set; }
    }
}
