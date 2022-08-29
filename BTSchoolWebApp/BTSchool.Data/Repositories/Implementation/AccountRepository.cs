using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using BTSchool.Core.DTOs;
using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories.Implementation
{
    internal class AccountRepository : Repository<Accounts>, IAccountRepository
    {
        public AccountRepository(AppContext context)
            : base(context)
        {
        }

        public Task<Accounts> GetAccountByCredentialsAsync(LoginModel login)
            => _appContext.Accounts.FirstOrDefaultAsync(a => a.Email == login.Email);

    }
}
