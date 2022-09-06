using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(BTSDataContext context)
            : base(context)
        {
        }
    }
}
