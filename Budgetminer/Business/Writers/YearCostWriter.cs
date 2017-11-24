using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgetminer.DataAccess.Entities;
using Budgetminer.DataAccess;

namespace Budgetminer.Business.Writers
{
    public class YearCostWriter : IYearCostWriter
    {
        private EntityContext _context;

        public YearCostWriter(EntityContext context)
        {
            _context = context ?? throw new ArgumentException($"{GetType().Name}.Ctor() parameter {nameof(context)} cannot be null.");
        }
        public Task Insert(YearCost yearCost)
        {
            throw new NotImplementedException();
        }

        public Task Update(YearCost yearCost, int id)
        {
            throw new NotImplementedException();
        }
    }
}
