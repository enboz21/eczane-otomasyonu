using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Interface;
using Entities;
using Entities.DTOs;
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

        public async Task<List<Stok>> GetAvailableBatchesOrderedByExpiryAsync(int Id)
        {
            return await _context.Stok
               .Where(s => s.IlacId == Id && s.MevcutAdet > 0)
               .OrderBy(s => s.SonKullanmaTarihi)
               .ToListAsync();
        }

        public async Task<List<StokDetayDTO>> StokDetay()
        {
            var temp = await _context.Stok
                .Include("Ilac")
                .Include("Tedarikci")
                .ToListAsync();
               
            return temp.Select(s => new StokDetayDTO
            {
                IlacAdi = s.Ilac != null ? s.Ilac.IlacAdi : string.Empty,
                TedarikciAdi = s.Tedarikci != null ? s.Tedarikci.TedarikciAdi : string.Empty,
                AlisTarihi = s.AlisTarihi,
                SonKullanmaTarihi = s.SonKullanmaTarihi,
                AlisFiyati = s.AlisFiyati,
                MevcutAdet = s.MevcutAdet
            }).ToList();





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
