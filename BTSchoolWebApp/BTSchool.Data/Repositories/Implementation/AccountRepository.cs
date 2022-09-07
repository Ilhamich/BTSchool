using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using BTSchool.Core.BindingModels;
using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(BTSDataContext context)
            : base(context)
        {
        }

        public async Task<Account> GetAccountByCredentialsAsync(AccountCredential login)
            => await _appContext.Accounts.FirstOrDefaultAsync(a => a.Email == login.Email
                    && a.Password == login.Password);

        public async Task<bool> IsAccountExist(string email)
            => await _appContext.Accounts.AnyAsync(a => a.Email == email);
    }
}
