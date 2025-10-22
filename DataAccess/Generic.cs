using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Generic<T> : IGeneric<T> where T : class
    {
        protected readonly Scontext _context;
        public Generic()
        {
            _context = new Scontext();
        }

        public Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChangesAsync();
        }

        public Task<List<T>> GetAll()
        {
            return _context.Set<T>().ToListAsync();
        }

        public Task<T> GetById(int id)
        {
            return _context.Set<T>().FindAsync(id).AsTask();
        }

        public Task Save(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        internal interface ISatisDetay
        {
        }
    }
}
