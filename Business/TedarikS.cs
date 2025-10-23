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
    public class TedarikS : ITedarikS
    {
        protected readonly ITedarikci _tedarikci;
        public TedarikS(ITedarikci tedarikci)
        {
            _tedarikci = tedarikci;
        }

        public Task Add(Tedarikci K)
        {
            if (String.IsNullOrWhiteSpace(K.TedarikciAdi))
            {
                throw new Exception("Tedarikçi Adı Boş Geçilemez");
            }
            return _tedarikci.Save(K);
        }

        public Task Delete(int id)
        {
            return _tedarikci.Delete(id);
        }

        public Task<List<Tedarikci>> GetAll()
        {
            return _tedarikci.GetAll();
        }

        public Task<Tedarikci> GetById(int id)
        {
            return _tedarikci.GetById(id);
        }

        public Task Update(Tedarikci K)
        {
            if (String.IsNullOrWhiteSpace(K.TedarikciAdi))
            {
                throw new Exception("Tedarikçi Adı Boş Geçilemez");
            }
            return _tedarikci.Update(K);
        }
    }
}
