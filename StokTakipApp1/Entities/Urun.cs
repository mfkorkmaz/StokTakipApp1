using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public int StokMiktari { get; set; }
        public DateTime EklemeTarihi { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
