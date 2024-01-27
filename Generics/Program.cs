using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List: classdır.
            //generic yapılar da arka planda bir array tutulur.
            List<string> sehirler = new List<string>();

            //sehirler.Count = 3; //get
            sehirler.Add("Ankara"); //add list in veri tipini istiyor 
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();    //generic değil bu şekilde tip argumanlarıyla kullanılamaz demektedir. Bu ne demek?
            
            sehirler2.Add("İstanbul"); //hangi tipi kullandıysam generic class olduğu için tip ona dönüşür.
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count); //0 verdi array yani eleman sayısını 1 arttırmamız gerekir. newlememiz gerek 
        }
    }

    class MyList<T> //GENERİC CLASS
    {
        T[] _array;
        T[] _tempArray; //yedek -geçici
        public MyList()
        {
            _array = new T[0]; // arka planda 0 elemanlı bir array çalıştırdık.
        }
        public void Add(T item)
        {
            _tempArray = _array;// temparrray aray ref tuttu.
            _array = new T[_array.Length + 1]; //Yeni ref alığımız için array elemanları tutamıyor. yedek almamız gerek.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _array[i]; // aktarma yapılıyor.
            }
            _array[_array.Length -1] = item; //0dan başladığı için indis bir azalttık.


        }

        //propfull - count oluştuuryoruz.
       

        public int Count
        {
            get { return _array.Length; } // count çapırdığımda mylist arrayın eleman sayısını bana verir.
            //set { _count = value; } set etmek istemiyoruz.
        }

    }
}