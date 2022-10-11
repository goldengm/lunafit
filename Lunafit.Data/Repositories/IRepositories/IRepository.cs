using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lunafit.Data.Repositories.IRepositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(object id);
        Task Insert(T obj);
        Task Insert(List<T> obj);
        Task Update(T obj);
        Task Delete(object id);

    }
}
