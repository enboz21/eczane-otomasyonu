using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SatisDetay
    {
        public int SatisDetayId { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }

        // Foreign Keys
        public int SatisId { get; set; }
        public int StokId { get; set; }
        public int IlacId { get; set; }

        [ForeignKey("SatisId")]
        public virtual Satis Satis { get; set; }
        [ForeignKey("StokId")]
        public virtual Stok Stok { get; set; }
        [ForeignKey("IlacId")]
        public virtual Ilac Ilac { get; set; }
    }
}
