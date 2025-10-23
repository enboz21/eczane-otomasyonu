using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Interface
{
    public interface IMarkaS
    {
        public Task Update(Marka K);
        public Task Delete(int id);
        public Task Add(Marka K);
        public Task<Marka> GetById(int id);
        public Task<List<Marka>> GetAll();
    }
}
