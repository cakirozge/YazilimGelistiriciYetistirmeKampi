using System;

namespace GenericsIntro;
class Program
{
    static void Main(string[] args)
    {
        //string tipinde liste programcı hangi tipi verirse T tipi ona dönüşür.
        MyList<string> isimler = new MyList<string>(); //Koleksiyonlar List arkada bir array tutar.
        isimler.Add("Engin");

        Console.WriteLine(isimler.Length);

        isimler.Add("Selin");
        Console.WriteLine(isimler.Length);

        isimler.Add("Ahmet");
        Console.WriteLine(isimler.Length);

        foreach (var item in isimler.Items) 
        {
            Console.WriteLine(item);
        }



    }
}