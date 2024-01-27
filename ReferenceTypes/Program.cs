using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int-decimal-float-enum-boolean:deger tip --value types
            //int sayi1 = 10; //sayı1 in değeri eşittir 10.
            //int sayi2 = 20;

            //sayi1 = sayi2; //sayı1 in degeri eşittir sayı 2 nin değeri (sayı2 ile bir bağlantııs yok burada.)
            //sayi2 = 100;

            //Console.WriteLine("Sayı 1: " + sayi1);

            ////array,class,interface.. reference types
            //int[] sayilar1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] sayilar2 = new int[] { 10, 20, 30, 40, 50 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayilar 1[0] : " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1; //deper eşitlemesi değil adres eşitlemesi yapıyoruz.
            person1.FirstName = "Derin"; //ikisininde ayn yerdeki bellekteki yerini değiştirmiş oluyoruz.
            Console.WriteLine("Person 2 First Name:" + person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456789";

            Employee employee = new Employee();
            employee.FirstName = person1.FirstName;

            //customer = employee; //farklı tip atanamaz.

            //nasıl person3ü customer a atayabildik?
            //Çünkü: customer bir person, employee person yani mirası alan classı atabailiriz. Buna base sınıf denir - Temel class: Person ebeveyn
            //Base class a onu ınherit eden classları atabiliriz.
            Person person3 = customer;
            customer.FirstName = "Ahmet"; //person customer adreslerini tutar

            //person3. customer credit bilgisini göremiyoruz fakat aynı adresleri tuttuğunu biliyoruz. Bunu ispatlayalım!

            
            //Console.WriteLine(((Customer)person3).CreditCardNumber); //boxing yaptık. customer içine
            PersonManager personManager = new PersonManager();
            personManager.Add(customer); //person3 ve customer ile çalıştı





        }
    }

    //class da ref typedır.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    //aynı kodu farklı nesneler için çalıştırabilmemize imkan sağlar.
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

