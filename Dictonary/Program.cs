using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>() { };
            myDictionary.Add(1, "Ahmet");
            myDictionary.Add(2, "Ayşe");

            Console.WriteLine(myDictionary.KLength + " Elemanlı ");
            Console.WriteLine();

            for (int i = 0; i < myDictionary.KLength; i++)
            {
                Console.WriteLine(myDictionary.CustomerK[i] + " numaralı Id : " + myDictionary.CustomerV[i]);
            }
        }


    }
    

    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
                keys = new Key[0];
                values = new Value[0];  
        }

        public void Add(Key id, Value firstName) 
        {
            Key[] _keysarray = keys;
            Value[] _valuesarray = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < _keysarray.Length; i++)
            {
                keys[i] = _keysarray[i];
                values[i] = _valuesarray[i];    
            }

            keys[keys.Length - 1] = id;
            values[values.Length - 1] = firstName;  
        }

        public int KLength
        {
            get { return keys.Length; }
        }

        public Key[] CustomerK
        {
            get { return keys; }
        }

        public Value[] CustomerV
        {
            get { return values; }


        }



    }

}