using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Urun ile ilgili operasyonları içerir.
    //Arama - ekleme - silme - filtreleme
    //void emir kipinde çağrı yapar.
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        // ----------------void mantığı ----------------------------
        // neden void var ve niye return (bir şeyi döndürme) var?
        //void: sadece emir kipiyle git, yap bitir bağlantı bitti.
        //fakat bizim örneğin bir bankacılık ugulamasında void yapan topla2nin sonucuna ihtiyacın doğar yani onu return etmemiz gerekir.
        //return: (verilen veri tipine göre kafasına göre değil) int tipinde değeri verir
        //topla için --> productManager.Topla(3, 6); returndur.
        //return ile üzerinde calısmak istediğimiz işlemler için kullanırız. örneğin çarpma veya listeleme, yeni bir eleman ekleme vs

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        // böyle olduğunda return yazamayız kırmızı verir.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
