using System.Collections.Generic;
using System.Threading.Tasks;

using BTSchool.Data.Entities;

namespace BTSchool.Buisness.ServiceInterfaces
{
    public interface IProductService
    {
        Task<IList<Products>> GetAllProductsAsync();
    }
}
