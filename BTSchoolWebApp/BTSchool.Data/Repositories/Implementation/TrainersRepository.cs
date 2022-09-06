using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class TrainersRepository : Repository<Trainer>, ITrainersRepository
    {
        public TrainersRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
