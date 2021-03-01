using SimpleProductCreation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductCreation.Core
{
    public interface IAsyncRepository<T> where T :BaseEntity
    {
        T Add(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        IReadOnlyList<T> ListAll();
    }
}
