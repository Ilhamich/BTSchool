using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class CustomerRepository : Repository<Customers>, ICustomerRepository
    {
        public CustomerRepository(AppContext context)
            : base(context)
        {
        }
    }
}
