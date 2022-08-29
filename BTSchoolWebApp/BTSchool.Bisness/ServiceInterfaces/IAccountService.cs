using BTSchool.Core.DTOs;
using BTSchool.Core.Entities;

using System.Threading.Tasks;

namespace BTSchool.Buisness.ServiceInterfaces
{
    public interface IAccountService
    {
        Task<Accounts> GetAccount(LoginModel accountLogin);
    }
}
