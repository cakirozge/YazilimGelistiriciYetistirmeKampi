using System;

namespace Inheritance
{
    //class tek başına bir anlamı vardır interface yoktur.
   
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"}, new Student{FirstName="Derin"}, new Person{FirstName="Salih"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
        
    }

    class Customer:Person// sadece bir kere inherit edilebilir inheritance  önce sonra implementasyonlar yazılır.
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Department { get; set; }
    }



}