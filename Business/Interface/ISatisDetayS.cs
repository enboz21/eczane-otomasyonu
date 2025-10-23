using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Interface
{
    public interface ISatisDetayS
    {
        public Task Update(SatisDetay sd);
        public Task Delete(int id);
        public Task Add(SatisDetay sd);
        public Task<SatisDetay> GetById(int id);
        public Task<List<SatisDetay>> GetAll();
        public Task<List<SatisDetay>> GetSdByDetay();
    }
}
