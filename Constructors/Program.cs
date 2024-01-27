using System;

namespace Constructor
{
    //Constructor:AMAÇ BİR SINIFININ İLK OLUŞMA ANINI KONTROL ETMEKTİR
    //Constructor: Bir classı newlediğimiz zaman çalışan bloktur. Yani bir classı ilk kez oluşturduğumuzda bir kere çalışır ve bir daha çalışmaz.
    class Program
    {
        static void Main(string[] args) 
        { 
            Customer customer1 = new Customer();
            customer1.Id = 1; // Bu kullanım ile customer2 kullanımı birbirine eşittir hiçbir farkı yok.
            //(); Bir class sonuna parantez açıp kapıyoruz sanki bir metot gibi. Aslında bir constructor bir metot gibi çalışır.
            //new Customer(); yazdığımız zaman default olarak public Customer(){} çalıştırırız.

            Customer customer2 = new Customer { Id = 1 , FirstName="Engin", LastName="Demiroğ", City="Ankara"}; //bu şekilde de bir class newlenebilir. //parametre geçince burası kızardı. Çözüm nedir?
            Customer customer3 = new Customer(2, "Derin", "Demiroğ", "Ankara"); //Bir fonksiyonmuş gibi.. böyle yazdığımızda Customer kızardı. Çözüm nedir?
                                                                                //Çözüm: constructor a parametreleri vermek zorundayız.
                                                                                // Metot(2, "fdlkfdkf", "kfdkfkfk", "kdkdkkd");

            Console.WriteLine(customer3.FirstName);
        }

    //    static void Metot(int id, string firstName, string lastName, string city)
    //    {

    //    }
    //}

    class Customer
    {
        //new Customer(); ile constructor çalışır default olarak.
        //Yaz yazma arka planda default constructor çalışır buna: default constructor denir.
        //constructorlar metot mantığı ile çalışır.
        //constructor a parametre verirsek default constructor ı ezmiş oluruz.
        //Customer3 de bu constructor çalıştı.
        public Customer(int id, string firstName, string lastName, string city) //ctor Clas ismi ile aynı sanki bir metot gibi ama void veya herhangi bir şeye sahip değil. 
        {      
            Id = id;
            FirstName = firstName; //gelen firstName eşitliyoruz. customer3 okuma yapabilmesi için gereklidir
            LastName = lastName; 
            City = city;
        }

        //customer1 ve customer2 de bu çalıştı çünkü {} yazdığımız bir parametre değil parametre vermedik, default constructor çalıştı.
        public Customer()
        {
            
        }
        public int Id { get; set; } 
        public string FirstName { get; set; }    
        public string LastName { get; set; } 
        public string City { get; set; }    
    }
}