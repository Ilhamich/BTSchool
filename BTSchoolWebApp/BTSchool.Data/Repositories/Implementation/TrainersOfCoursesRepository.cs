using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class TrainersOfCoursesRepository : Repository<TrainersOfCourses>, ITrainersOfCoursesRepository
    {
        public TrainersOfCoursesRepository(AppContext context)
            : base(context)
        {
        }
    }
}
