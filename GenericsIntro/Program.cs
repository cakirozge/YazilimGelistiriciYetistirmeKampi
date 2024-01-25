using System;

namespace GenericsIntro;
class Program
{
    static void Main(string[] args)
    {
        //string tipinde liste programcı hangi tipi verirse T tipi ona dönüşür.
        MyList<string> isimler = new MyList<string>(); //Koleksiyonlar List arkada bir array tutar.
        isimler.Add("Engin");
    }
}