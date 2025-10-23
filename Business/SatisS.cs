using Business.Interface;
using DataAccess.Interface;
using DataAccess;
using Entities;
namespace Business
{
    public class SatisS : ISatisS
    {
        protected readonly ISatis _satis;
        public SatisS()
        {
            _satis = new SatisD();
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
