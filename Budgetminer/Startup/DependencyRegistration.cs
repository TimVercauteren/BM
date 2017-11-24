using Budgetminer.Business.Readers;
using Budgetminer.Business.Readers.Base;
using Budgetminer.Business.Writers;
using Budgetminer.Business.Writers.Base;
using Budgetminer.DataAccess.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddServices (this IServiceCollection services)
        {

            //Readers
            services.AddTransient<IApplicationReader, ApplicationReader>();
            services.AddTransient<IYearCostReader, YearCostReader>();
            services.AddTransient<IComponentReader, ComponentReader>();

            //Writers
            services.AddTransient<IApplicationWriter, ApplicationWriter>();
            services.AddTransient<IYearCostWriter, YearCostWriter>();
            services.AddTransient<IComponentWriter, ComponentWriter>();

            return services;
        }
    }
}
