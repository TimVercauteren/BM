using Budgetminer.DataAccess;
using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Readers.Base
{
    public class ReaderBase<T> : IReaderBase<T> where T : EntityBase
    {
        private EntityContext _context;

        public ReaderBase(EntityContext context)
        {
            _context = context ?? throw new ArgumentException($"{GetType().Name}.Ctor() parameter {nameof(context)} cannot be null.");
        }
        public async Task<T> Get(int id)
        {
            try
            {
                var result = await _context.FindAsync<T>(id);
                return result;
            }
            catch
            {
                throw new ReaderException();
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                var result = _context.Set<T>().ToList();
                return result;
            }
            catch
            {
                throw new ReaderException();
            }
        }
    }
}
