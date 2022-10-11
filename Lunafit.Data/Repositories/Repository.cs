using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lunafit.Data.Repositories.IRepositories;

namespace Lunafit.Data.Repositories
{
    public class Repository<T>: RepositoryBase<T>, IRepository<T> where T : class
    {
        public Repository(LunafitDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await Dbset.ToListAsync();
        }
        public async Task<T> GetByID(object id)
        {
            return await Dbset.FindAsync(id);
        }
        public async Task Insert(T obj)
        {
            Dbset.Add(obj);
            await _dbContext.SaveChangesAsync();
        }
        public async Task Insert(List<T> obj)
        {
            Dbset.AddRange(obj);
            await _dbContext.SaveChangesAsync();
        }
        public async Task Update(T obj)
        {
            Dbset.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task Delete(object id)
        {
            T existing = await Dbset.FindAsync(id);
            Dbset.Remove(existing);
            await _dbContext.SaveChangesAsync();
        }

    }
}
