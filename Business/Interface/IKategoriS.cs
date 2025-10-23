using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Interface
{
    public interface IKategoriS
    {
        public Task Update(Kategori K);
        public Task Delete(int id);
        public Task Add(Kategori K);
        public Task<Kategori> GetById(int id);
        public Task<List<Kategori>> GetAll();
    }
}
