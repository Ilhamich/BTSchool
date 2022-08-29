using System.Threading.Tasks;

using BTSchool.Buisness.ServiceInterfaces;
using BTSchool.Core.DTOs;
using BTSchool.Core.Entities;
using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class AccountService : IAccountService
    {
        IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Accounts> GetAccount(LoginModel accountLogin)
            => _unitOfWork.AccountRepository.GetAccountByCredentialsAsync(accountLogin);     
    }
}
