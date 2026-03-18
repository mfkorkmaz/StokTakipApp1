using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Entities
{
    public class SatisDetay
    {
        public int Id { get; set; }
        public int Adet { get; set; }
        public double BirimFiyat { get; set; }
        public double ToplamFiyat { get; set; }

        public int SatisId { get; set; }
        public Satis Satis { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }
    }
}
