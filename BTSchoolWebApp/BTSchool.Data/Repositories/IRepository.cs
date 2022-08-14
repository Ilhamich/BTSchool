using System.Collections.Generic;
using System.Threading.Tasks;
using BTSchool.Data.Entities;

namespace BTSchool.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(long id);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);

        Task<bool> IsEntityExistAsync(long id);

        Task<IEnumerable<long>> GetNotExistEntitiesIdsAsync(IEnumerable<long> ids);

        Task UpdateRangeAsync(IEnumerable<T> entities);

        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
