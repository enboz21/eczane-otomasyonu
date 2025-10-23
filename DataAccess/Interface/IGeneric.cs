using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IGeneric<T> where T : class
    {
        public Task Save(T entity);
        public Task<List<T>> GetAll();
        public Task Delete(int id);
        public Task<T> GetById(int id);
        public Task Update(T entity);
    }
}
