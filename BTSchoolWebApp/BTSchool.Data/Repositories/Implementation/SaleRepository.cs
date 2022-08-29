using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class SaleRepository : Repository<Sales>, ISaleRepository
    {
        public SaleRepository(AppContext context)
            : base(context)
        {

        }
    }
}
