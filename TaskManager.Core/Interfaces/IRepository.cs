using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Interfaces
{
    public interface IRepository<T>
         where T : class
    {
        T Get(Guid id);
        T Get(ISpecification<T> specification);
        IList<T> List();
        IList<T> List(ISpecification<T> specification);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
