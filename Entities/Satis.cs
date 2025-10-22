using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Satis
    {
        public int SatisId { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public decimal ToplamTutar { get; set; }


        // Navigation property
        public virtual ICollection<SatisDetay> SatisDetaylar { get; set; } = new List<SatisDetay>();
    }
}
