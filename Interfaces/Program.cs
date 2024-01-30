using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3] 
            { 
                new OracleServerCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlServerCustomerDal() {}
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Department = "Computer Sciences"

            };


            manager.Add(student);
        }
    }
    

//bir interface newlenemez. instance oluşturamaz.
    interface IPerson
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
