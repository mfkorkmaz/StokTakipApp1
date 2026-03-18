using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipApp1.Repositories
{
    public interface IGenelRepository<T> where T : class
    {
        Task Ekle(T entity);
        Task Guncelle(T entity);
        Task Sil(int id);
        Task<T> IdileGetir(int id);
        Task<List<T>> HepsiniGetir();
    }
}
