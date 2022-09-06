using System.Threading.Tasks;

using BTSchool.Buisness.ServiceInterfaces;
using BTSchool.Core.BindingModels;
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

        public Task<Account> GetAccountByCredentialsAsync(AccountCredential accountLogin)
            => _unitOfWork.AccountRepository.GetAccountByCredentialsAsync(accountLogin);

        public async Task<bool> RegisterAccount(AccountRegister register)
        {
            if (!await _unitOfWork.AccountRepository.IsAccountExist(register.Email))
            {
                var regAccount = new Account()
                {
                    FirstName = register.Name,
                    LastName = register.Email,
                    Email = register.Email,
                    Password = register.Password
                };

                await _unitOfWork.AccountRepository.AddAsync(regAccount);

                await _unitOfWork.CommitAsync();

                return true;
            }

            return false;
        }
    }
}
