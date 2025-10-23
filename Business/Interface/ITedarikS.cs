using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Interface
{
    public interface ITedarikS
    {
        public Task Update(Tedarikci K);
        public Task Delete(int id);
        public Task Add(Tedarikci K);
        public Task<Tedarikci> GetById(int id);
        public Task<List<Tedarikci>> GetAll();
    }
}
