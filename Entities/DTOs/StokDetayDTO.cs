using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class StokDetayDTO
    {
        public String IlacAdi { get; set; }
        public String TedarikciAdi { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public decimal AlisFiyati { get; set; }
        public int MevcutAdet { get; set; }
    }
}
