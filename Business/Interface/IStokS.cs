using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.DTOs;

namespace Business.Interface
{
    public interface IStokS
    {
        public Task Update(Stok stok);
        public Task Delete(int id);
        public Task Add(Stok stok);
        public Task<Stok> GetById(int id);
        public Task<List<Stok>> GetAll();
        public Task<List<Stok>> GetStokByDetay();
        public Task<List<Stok>> GetAvailableBatchesOrderedByExpiryAsync(int Id);
        public Task<List<StokDetayDTO>> StokDetay();
    }
}
