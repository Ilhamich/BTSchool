using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class AccountantRepository : Repository<Accountant>, IAccountantRepository
    {
        public AccountantRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
