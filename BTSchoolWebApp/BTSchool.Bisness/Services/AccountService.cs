using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class AccountService
    {
        IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
