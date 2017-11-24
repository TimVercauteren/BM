﻿using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Writers
{
    interface IYearCostWriter
    {
        Task Insert(YearCost yearCost);
        Task Update(YearCost yearCost, int id);
    }
}
