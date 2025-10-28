using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SDDTO
    {
        public int SatisDetayId { get; set; }
        public int SatisId { get; set; }
        public int StokId { get; set; }
        public int IlacId { get; set; }
        public string IlacAdi { get; set; }
        public DateTime SonKullanımTariği { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        

    }
}
