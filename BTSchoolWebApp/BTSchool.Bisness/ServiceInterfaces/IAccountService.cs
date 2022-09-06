using BTSchool.Core.BindingModels;
using BTSchool.Core.Entities;

using System.Threading.Tasks;

namespace BTSchool.Buisness.ServiceInterfaces
{
    public interface IAccountService
    {
        Task<Account> GetAccountByCredentialsAsync(AccountCredential accountLogin);

        Task<bool> RegisterAccount(AccountRegister register);
    }
}
