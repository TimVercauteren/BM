using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgetminer.DataAccess.Entities;
using Budgetminer.DataAccess;

namespace Budgetminer.Business.Writers
{
    public class ComponentWriter : IComponentWriter
    {
        private EntityContext _context;

        public ComponentWriter(EntityContext context)
        {
            _context = context ?? throw new ArgumentException($"{GetType().Name}.Ctor() parameter {nameof(context)} cannot be null."); 
        }

        public Task Insert(Component component)
        {
            throw new NotImplementedException();
        }

        public Task Update(Component component, int id)
        {
            throw new NotImplementedException();
        }
    }
}
