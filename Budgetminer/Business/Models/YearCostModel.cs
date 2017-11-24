using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Models
{
    public class YearCostModel : ModelBase
    {
        public int Year { get; set; }
        public decimal LicenseDepreciation { get; set; }
        public decimal MaintenanceCost { get; set; }
    }
}
