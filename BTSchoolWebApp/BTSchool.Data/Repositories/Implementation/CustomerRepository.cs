using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
