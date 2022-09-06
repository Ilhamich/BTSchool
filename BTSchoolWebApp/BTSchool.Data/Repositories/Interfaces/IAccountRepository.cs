using BTSchool.Core.DTOs;
using BTSchool.Core.Entities;
using System.Threading.Tasks;

namespace BTSchool.Data.Repositories.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> GetAccountByCredentialsAsync(AccountCredential login);

        Task<bool> IsAccountExist(string email);
    }
}
