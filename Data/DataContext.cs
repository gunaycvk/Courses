using kurslar.Data;
using Microsoft.EntityFrameworkCore;

namespace Kurslar.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Kurs> Kurslar => Set<Kurs>();
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();

        public DbSet<KursKayit> KursKayıtları => Set<KursKayit>();


    }
}