using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class StokD : Generic<Stok>, IStok
    {
        public Task<List<Stok>> StokGetDetay()
        {
            return _context.Stoklar
                .Include(s => s.Ilac)
                .Include(s => s.Tedarikci)
                .ToListAsync();
        }
    }
}
