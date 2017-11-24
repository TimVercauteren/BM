using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Readers
{
    public interface IComponentReader
    {
        IEnumerable<Component> GetAll();
        Task<Component> Get(int componentId);
    }
}
