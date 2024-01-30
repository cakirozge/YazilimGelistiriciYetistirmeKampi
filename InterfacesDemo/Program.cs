using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workerS = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workerS)
            {
                worker.Work();
            }

            IEat[] eat = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };

            foreach (var worker in eat)
            {
                worker.Eat();
            }

            IGetSalary[] getSalaries = new IGetSalary[2] 
            { 
                new Worker(),
                new Manager(),
            };

            foreach (var worker in getSalaries)
            {
                worker.GetSalary();
            
            };

        }

        
    }

    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("yemek");
        }

        public void GetSalary()
        {
            Console.WriteLine("maaş");
        }

        public void Work()
        {
            Console.WriteLine("çalışan çalışması");
        }
    }

    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("yemek");
        }

        public void GetSalary()
        {
            Console.WriteLine("maaş");
        }

        public void Work()
        {
            Console.WriteLine("çalışan çalışması");
        }
    }

    class Robot : IWorker //İNTERFACE bazen bir durumu karşılamaz ve birden fazla interface tanımlamamız gerekir.
    {
        public void Work()
        {
            Console.WriteLine("çalışan çalışması");
        }
    }
}