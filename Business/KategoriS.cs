using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interface;
using DataAccess.Interface;
using DataAccess;
using Entities;
namespace Business
{
    public class KategoriS : IKategoriS
    {
        protected readonly IKategori _kategori;
        public KategoriS()
        {
            _kategori = new KategoriD();
        }

        public Task Add(Kategori K)
        {
            if (String.IsNullOrWhiteSpace(K.KategoriAdi))
            {
                throw new Exception("Kategori Adı Boş Geçilemez");
            }
            return _kategori.Save(K);
        }

        public Task Delete(int id)
        {
            return _kategori.Delete(id);
        }

        public Task<List<Kategori>> GetAll()
        {
            return _kategori.GetAll();
        }

        public Task<Kategori> GetById(int id)
        {
            return _kategori.GetById(id);
        }

        public Task Update(Kategori K)
        {
            if (String.IsNullOrWhiteSpace(K.KategoriAdi))
            {
                throw new Exception("Kategori Adı Boş Geçilemez");
            }
            return _kategori.Update(K);
        }
    }
}
