using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
