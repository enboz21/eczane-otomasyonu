using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Marka
    {
        public int MarkaId { get; set; }
        public string MarkaAd { get; set; }
        public bool Aktif { get; set; } = true;



        // Navigation property


        public virtual ICollection<Ilac> Ilaclar { get; set; }=new List<Ilac>();
    }
}
