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
        public string TedarikciAdi { get; set; }
        public String? Telefon { get; set; }
        public String? Adres { get; set; }
        public String? Eposta { get; set; }
        public bool Aktif { get; set; } = true;


        // Navigation property
        public virtual ICollection<Stok> Stoklar { get; set; } = new List<Stok>();
    }
}
