using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class ServiceRepository : Repository<Services>, IServiceRepository
    {
        public ServiceRepository(AppContext context)
            : base(context)
        {
        }
    }
}
