using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ilac
    {
        public int IlacId { get; set; }
        public string IlacAdi { get; set; }
        public String Barkod { get; set; }
        public String ReceteTuru { get; set; }
        public String Birim { get; set; }
        public decimal SatisFiyati { get; set; }
        public bool Aktif { get; set; } = true;


        // Foreign Keys
        public int? KategoriID { get; set; }
        public int? MarkaId { get; set; }

        [ForeignKey("KategoriID")]
        public virtual Kategori? Kategori { get; set; }
        [ForeignKey("MarkaId")]
        public virtual Marka? Marka { get; set; }

        // Navigation properties
        public virtual ICollection<Stok> Stoklar { get; set; } = new List<Stok>();
        public virtual ICollection<SatisDetay> SatisDetaylar { get; set; } = new List<SatisDetay>();
    }
}
