using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Interface
{
    public interface ISatisS
    {
        public Task Update(Satis K);
        public Task Delete(Satis K);
        public Task Add(Satis K);
        public Task<Satis> GetById(int id);
        public Task<List<Satis>> GetAll();
    }
}
