using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_EF.EntityFramework
{
    public class Urunler
    {   
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
        public string Aciklama { get; set; }
        //ürünlerin içerisinde kategori yer alacak her 1 ürün yalnızca bir kategoride yer
        //alabilecek
    }
}
