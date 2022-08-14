using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class SaleService
    {
        IUnitOfWork _unitOfWork;

        public SaleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
