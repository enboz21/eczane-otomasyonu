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
        public Generic(Scontext scontext)
        {
            _context = scontext;
        }

        public async Task Delete(int id)
        {

            var sil = await GetById(id);

            if (sil != null)
            {
                _context.Set<T>().Remove(sil);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
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

        public async Task Update(T entity)
        {

            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
