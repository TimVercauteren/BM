using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Readers
{
    interface IYearCostReader
    {
        IEnumerable<YearCost> GetAll();
        Task<YearCost> Get(int id);
    }
}
