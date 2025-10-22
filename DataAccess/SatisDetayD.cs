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
    public class SatisDetayD : Generic<SatisDetay>, ISatisDetay
    {
        public Task<List<SatisDetay>> SatisDetayGetAll()
        {
            return _context.SatisDetayları
                .Include(sd => sd.Satis)
                .Include(sd => sd.Stok)
                .Include(sd => sd.Ilac).ToListAsync();
        }
    }
}
