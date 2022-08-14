using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class AccountantService
    {
        IUnitOfWork _unitOfWork;

        public AccountantService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
