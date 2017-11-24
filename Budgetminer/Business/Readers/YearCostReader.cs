using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Budgetminer.DataAccess.Entities;
using Budgetminer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Budgetminer.Business.Readers.Base;

namespace Budgetminer.Business.Readers
{
    public class YearCostReader : ReaderBase<YearCost>, IYearCostReader 
    {

        public YearCostReader(EntityContext context) : base(context)
        {
        }
    }
}
