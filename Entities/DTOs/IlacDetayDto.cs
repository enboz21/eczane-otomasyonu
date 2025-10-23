namespace Entities.DTOs
{
    public class IlacDetayDto
    {
        public int IlacId { get; set; }

        public string IlacAdi { get; set; }
        public string Barkod { get; set; }
        public string KategoriAdi { get; set; } 
        public string MarkaAdi { get; set; }    
        public decimal SatisFiyati { get; set; }
        public string ReceteTuru { get; set; }
        public string Birim { get; set; }
        public bool Aktif { get; set; }
        public int KategoriID { get; set; }
        public int MarkaId { get; set; }
    }
}