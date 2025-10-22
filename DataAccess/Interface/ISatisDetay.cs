using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Interface
{
    public interface ISatisDetay : IGeneric<SatisDetay>
    {
        public Task<List<SatisDetay>> SatisDetayGetAll();
    }
}
