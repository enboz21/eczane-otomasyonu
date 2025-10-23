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
    public class SatisDetayS : ISatisDetayS
    {
        protected readonly ISatisDetay _satisDetay;
        public SatisDetayS()
        {
            _satisDetay = new SatisDetayD();
        }

        public Task Add(SatisDetay sd)
        {
            if (sd.Adet <=0)
            {
                throw new Exception("Adet 0'dan Büyük Olmalıdır");
            }
            else if (sd.BirimFiyat <=0)
            {
                throw new Exception("Birim Fiyat 0'dan Büyük Olmalıdır");
            }
            return _satisDetay.Save(sd);
        }

        public Task Delete(int id)
        {
            return _satisDetay.Delete(id);
        }

        public Task<List<SatisDetay>> GetAll()
        {
            return _satisDetay.GetAll();
        }

        public Task<SatisDetay> GetById(int id)
        {
            return _satisDetay.GetById(id);
        }

        public Task<List<SatisDetay>> GetSdByDetay()
        {
            return _satisDetay.SatisDetayGetAll();
        }

        public Task Update(SatisDetay sd)
        {
            if (sd.Adet <= 0)
            {
                throw new Exception("Adet 0'dan Büyük Olmalıdır");
            }
            else if (sd.BirimFiyat <= 0)
            {
                throw new Exception("Birim Fiyat 0'dan Büyük Olmalıdır");
            }
            return _satisDetay.Update(sd);
        }
    }
}
