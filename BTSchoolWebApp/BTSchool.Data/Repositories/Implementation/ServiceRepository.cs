using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ServiceRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
