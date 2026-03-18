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
    public class MusteriRepository : GenelRepository<Musteri>
    {
        public async Task<List<Musteri>> AdaGoreAra(string ad)
        {
            using (var db = new AppDbContext())
            {
                return await db.Musteriler
                    .Where(x => x.Ad.Contains(ad))
                    .ToListAsync();
            }
        }

        public async Task<Musteri> SatislarlaBirlikteGetir(int id)
        {
            using (var db = new AppDbContext())
            {
                return await db.Musteriler
                    .Include(x => x.Satislar)
                    .FirstOrDefaultAsync(x => x.Id == id);
            }
        }
    }
}
