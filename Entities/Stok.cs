using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Stok
    {
        public int StokId { get; set; }
        public DateTime AlisTarihi { get; set; } = DateTime.Now;
        public int Miktar { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public decimal AlisFiyati { get; set; }
        public int MevcutAdet { get; set; }



        // Foreign Keys
        public int IlacId { get; set; }
        public int? TedarikciId { get; set; }

        [ForeignKey("IlacId")]
        public virtual Ilac Ilac { get; set; }
        [ForeignKey("TedarikciId")]
        public virtual Tedarikci? Tedarikci { get; set; }


        //Navigation properties
        public virtual ICollection<SatisDetay> SatisDetaylar { get; set; } = new List<SatisDetay>();
    }
}
