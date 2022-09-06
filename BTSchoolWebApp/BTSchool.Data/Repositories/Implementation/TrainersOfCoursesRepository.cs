using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class TrainersOfCoursesRepository : Repository<TrainerOfCourse>, ITrainersOfCoursesRepository
    {
        public TrainersOfCoursesRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
