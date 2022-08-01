using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BTSchool.Core.Entities;
using BTSchool.Data.Repositories.Interfaces;

namespace BTSchool.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppContext _appContext;
        private DbSet<T> _entity;

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
            return await _entity.ToListAsync();
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
            throw new System.NotImplementedException();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}
