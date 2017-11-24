using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Writers.Base
{
    public interface IWriterBase<T> where T: EntityBase
    {
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
