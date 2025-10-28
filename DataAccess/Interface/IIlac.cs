using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.DTOs;

namespace DataAccess.Interface
{
    public interface IIlac : IGeneric<Ilac>
    {
        public Task<List<IlacDetayDto>> IlacGetDetay();
        Task<Ilac> GetByBarkodOrNameAsync(string s);
    }
}
