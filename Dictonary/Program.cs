using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int , string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "İstanbul");
            myDictionary.Add(2, "Giresun");
            Console.WriteLine(myDictionary.CountKey + " elemana sahiptir.");


            for (int i = 0; i < myDictionary.CountKey; i++)
            {
                Console.WriteLine("id: " + myDictionary.KeysK[i] +" " + "Sehir Adı: " + myDictionary.ValuesV[i]);
            }







            //List<string> sehirler = new List<string>();
            //sehirler.Add("Ankara");
            // sehirler.Add("Ankara");
            // sehirler.Add("Ankara");
            // Console.WriteLine(sehirler.Count);



            //MyList<string> sehirler2 = new MyList<string>();
            // sehirler2.Add("Giresun");
            // sehirler2.Add("Giresun");
            // sehirler2.Add("Giresun");
            // Console.WriteLine(sehirler2.Count);





        }

        class MyDictionary<Key, Value>
        {
            Key[] _keysArray;
            Value[] _valuesArray;


            Key[] _tempArray;
            Value[] _tempValue;
           
            public MyDictionary()
            {
                _keysArray = new Key[0];
                _valuesArray = new Value[0];
              
            }

            public void Add(Key keys, Value values)
            {
                _tempArray = _keysArray;
                 _keysArray = new Key[_keysArray.Length +1];

                _tempValue = _valuesArray;
                _valuesArray = new Value[_valuesArray.Length +1];

                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _keysArray[i] = _tempArray[i];
                    _valuesArray[i] = _tempValue[i];
  
                }

                _keysArray[_keysArray.Length - 1] = keys;
                _valuesArray[_valuesArray.Length - 1] = values;


            }

            public int CountKey
            {
                get { return _keysArray.Length; }
            }

            

            public Key[] KeysK
            {
                get { return _keysArray; }
                
            }

   
            public Value[] ValuesV
            {
                get { return _valuesArray; }







        }


    }

    //class MyList<T>
    //{
    //    T[] _array; //1. adım
    //    T[] _tempArray; // geçici --2.adım tutmak için

    //    public MyList()
    //    {
    //        _array = new T[0];
    //    }
    //    public void Add(T item) 
    //    {
    //        _tempArray = _array; //2. adım array ref tutumak için
    //        _array = new T[_array.Length +1]; //ELEMAN SAYISINI 1 ARTTIRDIK. TÜM DATA SİLİNİR ! //YEDEK ALMALIYIM. //1. adım

    //        for (int i = 0; i < _tempArray.Length; i++) //3. adım temparray kadar dönmeli
    //        {
    //            _array[i] = _tempArray[i];
    //        }

    //        _array[_array.Length-1] = item; //4. adım son gelen elemanı ekler.
    //    }

        

    //    public int Count // saydırma adımı dizi count eleman sayımızı bulduruyoruz.
    //    {
    //        get { return _array.Length; }
    //    }
            


    }
    

 
}

//----------------------------------------------------------------------------------------------
//MyDictionary<int, string> myDictionary = new MyDictionary<int, string>() { };
//myDictionary.Add(1, "Ahmet");
//myDictionary.Add(2, "Ayşe");

//Console.WriteLine(myDictionary.KLength + " Elemanlı ");
//Console.WriteLine();

//for (int i = 0; i < myDictionary.KLength; i++)
//{
//    Console.WriteLine(myDictionary.CustomerK[i] + " numaralı Id : " + myDictionary.CustomerV[i]);
//}


//--------------------------------------------------------------------------------------------------
//class MyDictionary<Key, Value>
//{
//    Key[] keys;
//    Value[] values;
//    public MyDictionary()
//    {
//            keys = new Key[0];
//            values = new Value[0];  
//    }

//    public void Add(Key id, Value firstName) 
//    {
//        Key[] _keysarray = keys;
//        Value[] _valuesarray = values;

//        keys = new Key[keys.Length + 1];
//        values = new Value[values.Length + 1];

//        for (int i = 0; i < _keysarray.Length; i++)
//        {
//            keys[i] = _keysarray[i];
//            values[i] = _valuesarray[i];    
//        }

//        keys[keys.Length - 1] = id;
//        values[values.Length - 1] = firstName;  
//    }

//    public int KLength
//    {
//        get { return keys.Length; }
//    }

//    public Key[] CustomerK
//    {
//        get { return keys; }
//    }

//    public Value[] CustomerV
//    {
//        get { return values; }


//    }



//}

