using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CodeFirst_EF.EntityFramework
{
    class Content:DbContext //kalıtımla content'teki değerleri alsın ki form'da kullanalım
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
    }
}
