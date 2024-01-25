using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array: oluşturduğumuz sınırlar içinde takılır.
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[0]);

            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[5]);
            //-----------------------------------------------------------------------
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);  

            //Çünkü: isimleri newlediğimizde yeni bir adres değişikliği ref no oluştu ilk newlenen isimlerle tüm ilişiğimiz kesildi.
            //Şunu demek istiyorum 5 elemana sahip yeni bir isimler ref nolu [] oluştu.
            //Bu nedenle dizi genişletemiyoruz, genişletirsek değerlerimizi kaybediyoruz. 0. elemanı okuyamıyor.
            //Bu nedenle koleksiyonlar kullanılır.
            //Bu durumu önlemek için yeni adreslenen ref no için biz List faydalanarak değerlerimizi hem kaybetmeyiz em de array gibi davranan çok daha geniş bir yapı kullanırız.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //List yeni eleman eklerken add kullandık.
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]); 

        }
    }
}
