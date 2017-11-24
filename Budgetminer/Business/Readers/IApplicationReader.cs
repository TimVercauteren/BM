using Budgetminer.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Budgetminer.Business.Readers
{
    public interface IApplicationReader
    {
        IEnumerable<Application> GetAll();
        Task<Application> Get(int appId);
    }
}