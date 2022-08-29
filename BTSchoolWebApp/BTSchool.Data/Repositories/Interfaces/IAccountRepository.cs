using BTSchool.Core.DTOs;
using BTSchool.Core.Entities;
using System.Threading.Tasks;

namespace BTSchool.Data.Repositories.Interfaces
{
    public interface IAccountRepository : IRepository<Accounts>
    {
        Task<Accounts> GetAccountByCredentialsAsync(LoginModel login);
    }
}
