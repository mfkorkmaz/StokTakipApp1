using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Entities
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
