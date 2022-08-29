using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class AccountantRepository : Repository<Accountants>, IAccountantRepository
    {
        public AccountantRepository(AppContext context)
            : base(context)
        {
        }
    }
}
