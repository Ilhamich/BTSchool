using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class ServicesOfCoursesRepository : Repository<ServicesOfCourses>, IServicesOfCoursesRepository
    {
        public ServicesOfCoursesRepository(AppContext context)
            : base(context)
        {
        }
    }
}
