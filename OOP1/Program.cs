using OOP1;
using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";  
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id =2, CategoryId=5, 
                UnitsInStock=6, UnitPrice=100, ProductName ="Kalem"};

            //instance bir class örneği

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);    




        }
    }
}

//HATIRLATICI !
//productManager.Topla2(3, 6);

//int toplamaSonucu = productManager.Topla(3, 6);
//Console.WriteLine("Toplama sonucu: " + toplamaSonucu*2);