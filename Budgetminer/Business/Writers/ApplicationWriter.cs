using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgetminer.DataAccess.Entities;
using Budgetminer.DataAccess;

namespace Budgetminer.Business.Writers
{
    public class ApplicationWriter : IApplicationWriter
    {
        private EntityContext _context;

        public ApplicationWriter(EntityContext context)
        {
            _context = context ?? throw new ArgumentException($"{GetType().Name}.Ctor() parameter {nameof(context)} cannot be null."); 
        }

        public void Insert(Application application)
        {
            try
            {
                _context.Applications.Add(application);
                _context.SaveChangesAsync();
            }
            catch 
            {
                throw new WriterException();
            }
        }

        public void Update(Application application, int id)
        {
            try
            {
                if (id == application.Id)
                {
                    _context.Applications.Update(application);
                    _context.SaveChangesAsync();
                }
                else
                    throw new WriterException();
            }
            catch
            {
                throw new WriterException();
            }
        }
    }
}
