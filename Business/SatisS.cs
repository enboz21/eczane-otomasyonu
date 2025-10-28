using Business.Interface;
using DataAccess;
using DataAccess.Interface;
using Entities;
using Entities.DTOs;
namespace Business
{
    public class SatisS : ISatisS
    {
        protected readonly ISatis _satis;
        protected readonly IStok _stok;
        protected readonly ISatisDetay _satisDetay;
        public SatisS(ISatis satis, IStok stok, ISatisDetay satisDetay)
        {
            _satis = satis;
            _stok = stok;
            _satisDetay = satisDetay;
        }

        public Task Add(Satis K)
        {
            if (K.ToplamTutar <=0)
            {
                throw new Exception("Toplam Tutar 0 dan Büyük Olmalıdır");
            }
            return _satis.Save(K);
        }

        public Task Delete(int id)
        {
            return _satis.Delete(id);
        }

        public Task<List<Satis>> GetAll()
        {
            return _satis.GetAll();
        }

        public Task<Satis> GetById(int id)
        {
            return _satis.GetById(id);
        }

        public async Task PerformSale(Satis satis, List<SDDTO> detaylar)
        {
            if (satis == null || detaylar == null || !detaylar.Any())
            {
                throw new ArgumentException("Satış bilgileri veya sepet boş olamaz.");
            }
            satis.ToplamTutar = detaylar.Sum(d => d.Adet * d.BirimFiyat);
            satis.Tarih = DateTime.Now;
            await _satis.Save(satis);
            if (satis.SatisId <= 0)
            {
                throw new Exception("Satış başlığı kaydedilemedi veya ID alınamadı.");
            }
            foreach (var detay in detaylar)
            {
                Stok ilgiliStok = await _stok.GetById(detay.StokId);
                if (ilgiliStok == null)
                    throw new Exception($"Satılmaya çalışılan stok (ID: {detay.StokId}) veritabanında bulunamadı!");
                if (ilgiliStok.MevcutAdet < detay.Adet)
                {
                    throw new InvalidOperationException($"Yetersiz Stok! Ürün ID: {ilgiliStok.IlacId}, Stok ID: {ilgiliStok.StokId}. Kalan: {ilgiliStok.MevcutAdet}, İstenen: {detay.Adet}");
                }

                ilgiliStok.MevcutAdet -= detay.Adet;
                await _stok.Update(ilgiliStok);
                
                detay.SatisId = satis.SatisId;

                SatisDetay detayEntity = new SatisDetay
                {
                    SatisId = detay.SatisId,
                    StokId = detay.StokId,
                    IlacId = detay.IlacId,
                    Adet = detay.Adet,
                    BirimFiyat = detay.BirimFiyat,
                    SatisDetayId = detay.SatisDetayId,
                };


                await _satisDetay.Save(detayEntity);
            }


        }

        public Task Update(Satis K)
        {
            if (K.ToplamTutar <= 0)
            {
                throw new Exception("Toplam Tutar 0 dan Büyük Olmalıdır");
            }
            return _satis.Update(K);
        }
    }
}
