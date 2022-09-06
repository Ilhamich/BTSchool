using System.Collections.Generic;
using System.Threading.Tasks;

using BTSchool.Core.Entities;

namespace BTSchool.Buisness.ServiceInterfaces
{
    public interface IProductService
    {
        Task<IList<Product>> GetAllProductsAsync();
    }
}
