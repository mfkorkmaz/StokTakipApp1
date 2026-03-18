using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Entities
{
    public class Satis
    {
        public int Id { get; set; }
        public DateTime SatisTarihi { get; set; }
        public double ToplamTutar { get; set; }

        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public List<SatisDetay> SatisDetaylar { get; set; }
    }
}
