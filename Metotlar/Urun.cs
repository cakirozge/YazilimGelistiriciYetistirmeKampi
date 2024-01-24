using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Urun
    {
        //Property - Urunun Özellikleri
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}

//Neden Class yaparız?
//Classlar özellik tutar. Örnek: Müşterinin Adı, TC No vb
//Id: bir datayı diğerlerinden ayırt etmemizi sağlayan eşsiz değeri yansıtır.