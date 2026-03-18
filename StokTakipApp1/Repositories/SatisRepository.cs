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
    public class SatisRepository : GenelRepository<Satis>
    {
        public async Task<List<Satis>> TumunuDetayliGetir()
        {
            using (var db = new AppDbContext())
            {
                return await db.Satislar
                    .Include(x => x.Musteri)
                    .Include(x => x.SatisDetaylar)
                        .ThenInclude(x => x.Urun)
                    .ToListAsync();
            }
        }

        public async Task<Satis> DetayliGetir(int id)
        {
            using (var db = new AppDbContext())
            {
                return await db.Satislar
                    .Include(x => x.Musteri)
                    .Include(x => x.SatisDetaylar)
                        .ThenInclude(x => x.Urun)
                    .FirstOrDefaultAsync(x => x.Id == id);
            }
        }
    }
}
