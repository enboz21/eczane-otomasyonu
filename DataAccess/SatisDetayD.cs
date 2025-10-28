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
    public class SatisDetayD : Generic<SatisDetay>, ISatisDetay
    {
        protected readonly Scontext _context;
        public SatisDetayD(Scontext context) : base(context)
        {
            _context = context;
        }

        public Task<List<SatisDetay>> SatisDetayGetAll()
        {
            return _context.SatisDetaylari
                .Include(sd => sd.Satis)
                .Include(sd => sd.Stok)
                .Include(sd => sd.Ilac).ToListAsync();
        }
    }
}
