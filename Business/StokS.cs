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
    public class StokS : IStokS
    {
        protected readonly IStok _stok;
        public StokS(IStok stok)
        {
            _stok = stok;
        }

        public Task Add(Stok stok)
        {
            if (stok.SonKullanmaTarihi <= DateTime.Now)
            {
                throw new Exception("Son Kullanma Tarihi Geçmiş Bir Tarih Olamaz");
            }
            else if (stok.MevcutAdet < 0)
            {
                throw new Exception("Mevcut Adet 0'dan Küçük Olamaz");
            }
            else if (stok.AlisFiyati <= 0)
            {
                throw new Exception("Alış Fiyatı 0'dan Küçük veya Eşit Olamaz");
            }
            return _stok.Save(stok);
        }

        public Task Delete(int id)
        {
            return _stok.Delete(id);
        }

        public Task<List<Stok>> GetAll()
        {
            return _stok.GetAll();
        }

        public Task<Stok> GetById(int id)
        {
            return _stok.GetById(id);
        }

        public Task<List<Stok>> GetStokByDetay()
        {
            return _stok.StokGetDetay();
        }

        public Task Update(Stok stok)
        {
            if (stok.SonKullanmaTarihi <= DateTime.Now)
            {
                throw new Exception("Son Kullanma Tarihi Geçmiş Bir Tarih Olamaz");
            }
            else if (stok.MevcutAdet < 0)
            {
                throw new Exception("Mevcut Adet 0'dan Küçük Olamaz");
            }
            else if (stok.AlisFiyati <= 0)
            {
                throw new Exception("Alış Fiyatı 0'dan Küçük veya Eşit Olamaz");
            }
            return _stok.Update(stok);
        }
    }
}
