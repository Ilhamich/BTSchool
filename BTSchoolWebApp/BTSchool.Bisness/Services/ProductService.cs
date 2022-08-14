using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class ProductService
    {
        IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
