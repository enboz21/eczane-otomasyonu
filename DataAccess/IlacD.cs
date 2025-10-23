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
    public class IlacD : Generic<Ilac>, IIlac
    {
        protected readonly Scontext _context;
        public IlacD(Scontext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<IlacDetayDto>> IlacGetDetay()
        {
            var a = await _context.Ilaclar
                .Include("Kategori")
                .Include("Marka")
                .ToListAsync();

            return a.Select(i => new IlacDetayDto
            {
                IlacId = i.IlacId,
                IlacAdi = i.IlacAdi,
                Barkod = i.Barkod,
                KategoriAdi = i.Kategori != null ? i.Kategori.KategoriAdi : string.Empty,
                MarkaAdi = i.Marka != null ? i.Marka.MarkaAdi : string.Empty,
                SatisFiyati = i.SatisFiyati,
                ReceteTuru = i.ReceteTuru,
                Birim = i.Birim,
                Aktif = i.Aktif,
                KategoriID = i.Kategori.KategoriID,
                MarkaId = i.Marka.MarkaId
            }).ToList();


        }
    }
}
