using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class TrainersOfGroupsRepository : Repository<TrainerOfCourse>, ITrainersOfGroupsRepository
    {
        public TrainersOfGroupsRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
