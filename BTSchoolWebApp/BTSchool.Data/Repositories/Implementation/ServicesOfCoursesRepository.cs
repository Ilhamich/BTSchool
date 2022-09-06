using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class ServicesOfCoursesRepository : Repository<ServiceOfCourse>, IServicesOfCoursesRepository
    {
        public ServicesOfCoursesRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
