using Microsoft.EntityFrameworkCore;
using StokTakipApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Repositories
{
    public class GenelRepository<T> : IGenelRepository<T> where T : class
    {
        public async Task Ekle(T entity) 
        {
            using(var db=new AppDbContext()) 
            {
                db.Set<T>().Add(entity);
                await db.SaveChangesAsync();
            }
        }
        public async Task Guncelle(T entity) 
        {
            using (var db = new AppDbContext()) 
            {
                db.Set<T>().Update(entity);
                await db.SaveChangesAsync();
            }
        }
        public async Task Sil(int id)
        {
            using (var db = new AppDbContext())
            {
                var entity = await db.Set<T>().FindAsync(id);
                if (entity != null)
                {
                    db.Set<T>().Remove(entity);
                    await db.SaveChangesAsync();
                }
            }
        }
        public async Task<T> IdileGetir(int id)
        {
            using (var db = new AppDbContext())
            {
                return await db.Set<T>().FindAsync(id);
            }
        }

        public async Task<List<T>> HepsiniGetir()
        {
            using (var db = new AppDbContext())
            {
                return await db.Set<T>().ToListAsync();
            }
        }
    }
}
