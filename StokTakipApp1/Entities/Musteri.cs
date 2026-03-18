using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipApp1.Entities
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }

        public List<Satis> Satislar { get; set; }
    }
}
