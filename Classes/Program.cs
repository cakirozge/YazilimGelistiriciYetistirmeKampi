using System;

namespace Classes
{
    //Class bir diğer özelliği property dediğimiz nesneleri tutar.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //bir ref oluştururuz. //instance camelCase döndü
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();  
            
            Customer customer = new Customer();
            customer.City = "Ankara"; //bir classın propertysini esitlediğimiz zaman bizim için prop set bloğu çalışır değeri veririz,kurarız.
            customer.FirsName = "Engin"; //set bloğu çalıştı property de bulunan (eşitlediğimizde)
            customer.Id = 1;
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer 
            {
                Id= 2,
                FirsName = "Derin",
                LastName = "Demiroğ",
                City = "Ankara"
            };

            Console.WriteLine(customer2.FirsName); //customer2.FirsName --> eşitlik yok get al customer2'nin firstName'ini al


        }
    }
}