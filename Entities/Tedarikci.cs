using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tedarikci
    {
        public int TedarikciId { get; set; }
        public string TedarikciAd { get; set; }
        public String? Tedarikcitel { get; set; }
        public String? TedarikciAdres { get; set; }
        public String? TedarikciEmail { get; set; }
        public bool Aktif { get; set; } = true;


        // Navigation property
        public virtual ICollection<Stok> Stoklar { get; set; } = new List<Stok>();
    }
}
