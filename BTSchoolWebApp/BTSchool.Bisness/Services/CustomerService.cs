using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class CustomerService
    {
        IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
