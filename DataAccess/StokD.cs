using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class StokD : Generic<Stok>, IStok
    {
        protected readonly Scontext _context;
        public StokD(Scontext context) : base(context)
        {
            _context = context;
        }

        public Task<List<Stok>> StokGetDetay()
        {
            return _context.Stok
                .Include(s => s.Ilac)
                .Include(s => s.Tedarikci)
                .ToListAsync();
        }
    }
}
