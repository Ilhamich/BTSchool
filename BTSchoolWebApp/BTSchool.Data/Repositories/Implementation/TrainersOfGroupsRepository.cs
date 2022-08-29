using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class TrainersOfGroupsRepository : Repository<TrainersOfCourses>, ITrainersOfGroupsRepository
    {
        public TrainersOfGroupsRepository(AppContext context)
            : base(context)
        {
        }
    }
}
