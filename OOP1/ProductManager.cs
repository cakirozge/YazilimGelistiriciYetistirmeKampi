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
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
