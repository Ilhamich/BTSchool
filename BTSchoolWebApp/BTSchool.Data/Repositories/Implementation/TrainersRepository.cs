using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class TrainersRepository : Repository<Trainers>, ITrainersRepository
    {
        public TrainersRepository(AppContext context)
            : base(context)
        {
        }
    }
}
