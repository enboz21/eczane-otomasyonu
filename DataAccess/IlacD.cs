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
    public class IlacD : Generic<Ilac>, IIlac
    {
        public Task<List<Ilac>> IlacGetDetay()
        {
            return _context.Ilaclar
                .Include(i => i.Kategori)
                .Include(i => i.Marka)
                .ToListAsync();
        }
    }
}
