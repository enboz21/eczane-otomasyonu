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
    public class MarkaS : IMarkaS
    {
        protected readonly IMarka _marka;
        public MarkaS()
        {
            _marka = new MarkaD();
        }
        public Task Add(Marka K)
        {
            if (String.IsNullOrWhiteSpace(K.MarkaAdi))
            {
                throw new Exception("Marka Adı Boş Geçilemez");
            }
            return _marka.Save(K);
        }

        public Task Delete(int id)
        {
            return _marka.Delete(id);
        }

        public Task<List<Marka>> GetAll()
        {
            return _marka.GetAll();
        }

        public Task<Marka> GetById(int id)
        {
            return _marka.GetById(id);
        }

        public Task Update(Marka K)
        {
            if (String.IsNullOrWhiteSpace(K.MarkaAdi))
            {
                throw new Exception("Marka Adı Boş Geçilemez");
            }
            return _marka.Update(K);
        }
    }
}
