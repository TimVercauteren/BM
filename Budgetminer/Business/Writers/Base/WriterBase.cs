using Budgetminer.Business.Readers.Base;
using Budgetminer.DataAccess;
using Budgetminer.DataAccess.Entities;
using System;
using System.Threading.Tasks;

namespace Budgetminer.Business.Writers.Base
{
    public class WriterBase<T> : IWriterBase<T> where T: EntityBase
    {
        private EntityContext _context;
        private IReaderBase<T> _reader;

        public WriterBase(EntityContext context, IReaderBase<T> reader)
        {
            _context = context ?? throw new ArgumentException($"{GetType().Name}.Ctor() parameter {nameof(context)} cannot be null.");
            _reader = reader ?? throw new ArgumentException($"{GetType().Name}.Ctor() parameter {nameof(reader)} cannot be null.");
        }

        public async Task Delete(T entity)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new WriterException();
            }
        }

        public async Task Delete (int id)
        {
            var entity = await _reader.Get(id);
            await Delete(entity as T);
        }

        public async Task Insert(T entity)
        {
            try
            {
                _context.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new WriterException();
            }
        }

        public async Task Update(T entity)
        {
            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new WriterException();
            }
        }
    }
}
