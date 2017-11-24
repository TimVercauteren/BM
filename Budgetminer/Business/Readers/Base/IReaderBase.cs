using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Readers.Base
{
    public interface IReaderBase<T> where T: EntityBase
    {
        Task<T> Get(int id);
        IEnumerable<T> GetAll();
    }
}
