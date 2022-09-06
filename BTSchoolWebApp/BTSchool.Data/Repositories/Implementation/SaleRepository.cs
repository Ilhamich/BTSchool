using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;


namespace BTSchool.Data.Repositories.Implementation
{
    internal class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(BTSDataContext context)
            : base(context)
        {

        }
    }
}
