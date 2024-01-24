using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        //naming convention 
        //Ekle() normal parantez görürseniz orada metot çalışıyor demektir!
        //metoda ne eklemek istediğimizi vermek zorundayız. Buna parametre denir.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi. : " + urun.Adi);
        }
        
        //hatalı kullanım
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}



//SepetManager ile ilgili bilgiler
//Bir class'ın sonunda Manager-Service-Dal-DataAccess-Controller vb ifadeler bunlar bir operasyon tutuyor demektir.
//Ortak kodları class içine yazarız. Örneğin sepet işlemleri sepete ekleme, sepetten çıkarma vb tutulduğu yer Manager adlı ilgili classlardır.
//Bir class içinde birden fazla metot olabilir.
