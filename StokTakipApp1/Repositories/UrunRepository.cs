using Microsoft.EntityFrameworkCore;
using StokTakipApp1.Data;
using StokTakipApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Repositories
{
    public class UrunRepository : GenelRepository<Urun>
    {
        public async Task<List<Urun>> KategoriyeGoreGetir(int kategoriId)
        {
            using (var db = new AppDbContext())
            {
                return await db.Urunler
                    .Include(x => x.Kategori)
                    .Where(x => x.KategoriId == kategoriId)
                    .ToListAsync();
            }
        }

        public async Task<List<Urun>> DusukStokGetir(int esik)
        {
            using (var db = new AppDbContext())
            {
                return await db.Urunler
                    .Include(x => x.Kategori)
                    .Where(x => x.StokMiktari < esik)
                    .ToListAsync();
            }
        }

        public async Task<List<Urun>> TumunuKategoriyleGetir()
        {
            using (var db = new AppDbContext())
            {
                return await db.Urunler
                    .Include(x => x.Kategori)
                    .ToListAsync();
            }
        }
    }
}
