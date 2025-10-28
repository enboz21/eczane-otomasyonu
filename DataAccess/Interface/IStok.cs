using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.DTOs;

namespace DataAccess.Interface
{
    public interface IStok : IGeneric<Stok>
    {
        public Task<List<Stok>> StokGetDetay();
        public Task<List<Stok>> GetAvailableBatchesOrderedByExpiryAsync(int Id);
        public Task<List<StokDetayDTO>> StokDetay();
    }
}
