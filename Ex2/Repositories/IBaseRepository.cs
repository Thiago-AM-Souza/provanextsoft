using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2.Repositories
{
    interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(int id);
        Task Insert(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}
