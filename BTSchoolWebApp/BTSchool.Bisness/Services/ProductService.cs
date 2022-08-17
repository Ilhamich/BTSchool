using System.Collections.Generic;
using System.Threading.Tasks;

using BTSchool.Buisness.ServiceInterfaces;
using BTSchool.Data.Entities;
using BTSchool.Data.Repositories;

namespace BTSchool.Buisness.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;
        
        public async Task<IList<Products>> GetAllProductsAsync() 
            => await _unitOfWork.ProductRepository.GetAllAsync();      
    }
}
