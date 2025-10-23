using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.DTOs;
namespace Business.Interface
{
    public interface IIlacS
    {
        public Task Update(Ilac ilac);
        public Task Delete(int id);
        public Task Add(Ilac ilac);
        public Task<Ilac> GetById(int id);
        public Task<List<Ilac>> GetAll();
        public Task<List<IlacDetayDto>> GetIlacByDetay();
    }
}
