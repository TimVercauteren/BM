using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Models
{
    public class ComponentModel : ModelBase
    {
        public string Name { get; set; }
        public decimal LicenseCost { get; set; }
        public decimal MainCost { get; set; }
        public decimal YearPercentIncrease { get; set; }
        public string BudgetOwner { get; set; }
    }
}
