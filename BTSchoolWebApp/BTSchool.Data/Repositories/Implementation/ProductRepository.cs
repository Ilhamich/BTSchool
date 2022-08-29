using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class ProductRepository : Repository<Products>, IProductRepository
    {
        public ProductRepository(AppContext context)
            : base(context)
        {
        }
    }
}
