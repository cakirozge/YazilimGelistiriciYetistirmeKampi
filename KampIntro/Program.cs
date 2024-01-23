using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //deger tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000; //belli bir sayı tutabilir -->tamsayı
            double faizOrani = 1.45; //ondalıklı sayi

            //true: gerçek projelerde bir veri kaynağından gelir. fonk gerekir tekrar tekrar kullanabilmek için.
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Eşittir oku");
            }


           if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
          
        }
    }
}

