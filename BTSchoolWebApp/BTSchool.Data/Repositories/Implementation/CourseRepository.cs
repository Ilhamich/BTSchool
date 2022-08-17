using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class CourseRepository : Repository<Courses>, ICourseRepository
    {
        public CourseRepository(AppContext context)
            : base(context)
        {
        }
    }
}
