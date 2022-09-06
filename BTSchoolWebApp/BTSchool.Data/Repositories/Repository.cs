using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BTSchool.Core.Entities;

namespace BTSchool.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly BTSDataContext _appContext;
        private DbSet<T> _entity;

        public Repository(BTSDataContext appContext)
        {
            _appContext = appContext;
            _entity = _appContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _entity.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _entity.AddRangeAsync(entities);
        }

        public async Task RemoveAsync(T entity)
        {
            await Task.Run(() => _entity.Remove(entity));
        }

        public async Task<List<T>> GetAllAsync()
        {
            var value = await _entity.ToListAsync();

            return value;
        }

        public async Task<T> GetByIdAsync(long id)
        {
           return await _entity.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task<IEnumerable<long>> GetNotExistEntitiesIdsAsync(IEnumerable<long> ids)
        {
            var existIds =  await _entity.Where(entity => ids.Contains(entity.Id))
                                         .Select(entity => entity.Id)
                                         .ToListAsync();

            return await Task.FromResult(ids.Except(existIds)); 
        }

        public async Task<bool> IsEntityExistAsync(long id)
        {
            return await _entity.AnyAsync(entity => entity.Id == id);
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
           await Task.Run(() =>_entity.RemoveRange(entities));
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _entity.Update(entity));
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            await Task.Run(() => _entity.UpdateRange(entities));
        }
    }
}
