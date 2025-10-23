using Business.Interface;
using DataAccess;
using DataAccess.Interface;
using Entities;
using Entities.DTOs;
namespace Business
{
    public class IlacS : IIlacS
    {
        protected readonly IIlac _ilac;
        public IlacS()
        {
            _ilac = new IlacD();
        }

        public Task Add(Ilac ilac)
        {
            if (String.IsNullOrWhiteSpace(ilac.IlacAdi))
            {
                throw new Exception("İlaç Adı Boş Geçilemez");
            }
            else if (String.IsNullOrWhiteSpace(ilac.Barkod))
            {
                throw new Exception("Barkod Boş Geçilemez");
            }
            else if (String.IsNullOrWhiteSpace(ilac.ReceteTuru))
            {
                throw new Exception("ReçeteTürü Boş Geçilemez");
            }
            else if (ilac.SatisFiyati <=0)
            {
                throw new Exception("Satış Fiyatı 0'dan Büyük Olmalıdır");
            }
            return _ilac.Save(ilac);

        }

        public Task Delete(int id)
        {
            return _ilac.Delete(id);
        }

        public Task<List<Ilac>> GetAll()
        {
            return _ilac.GetAll();
        }

        public Task<Ilac> GetById(int id)
        {
            return _ilac.GetById(id);
        }

        public Task<List<IlacDetayDto>> GetIlacByDetay()
        {
            return _ilac.IlacGetDetay();
        }

        public Task Update(Ilac ilac)
        {
            if (String.IsNullOrWhiteSpace(ilac.IlacAdi))
            {
                throw new Exception("İlaç Adı Boş Geçilemez");
            }
            else if (String.IsNullOrWhiteSpace(ilac.Barkod))
            {
                throw new Exception("Barkod Boş Geçilemez");
            }
            else if (String.IsNullOrWhiteSpace(ilac.ReceteTuru))
            {
                throw new Exception("ReçeteTürü Boş Geçilemez");
            }
            else if (ilac.SatisFiyati <= 0)
            {
                throw new Exception("Satış Fiyatı 0'dan Büyük Olmalıdır");
            }
            return _ilac.Update(ilac);
        }
    }
}
