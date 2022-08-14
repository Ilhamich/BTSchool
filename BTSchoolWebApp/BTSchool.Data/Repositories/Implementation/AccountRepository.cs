using BTSchool.Data.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{   
    internal class AccountRepository : Repository<Accounts>, IAccountRepository
    {
        public AccountRepository(AppContext context)
            : base(context)
        {
        }
    }
}
