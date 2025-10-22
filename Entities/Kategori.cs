using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }


        // Navigation property

        public virtual ICollection<Ilac> Ilaclar { get; set; } = new List<Ilac>();
    }
}
