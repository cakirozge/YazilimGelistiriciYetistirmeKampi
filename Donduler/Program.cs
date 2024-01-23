using System;

namespace KampIntro;

class Program
{
    //donguler birşeyleri tekrar etmek için kullanılan yapılardır.
    static void Main(string[] args)
    {
        //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        //string kurs2 = "Programnlamaya başlangıç için temel kurs";
        //string kurs3 = "Java";

        //bu verileri array-dizide tutarız.
        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya başlangıç için temel kurs", "Java", "Python Kursu", "C#" };

        //i bir sayaç 1den başla i<10 bu şartımızdır. i++ arttır birer birer.
        //length: eleman sayı dizideki eleman sayısını verir uzunluk.
        //for daha genel amaçlar için kullanılır foreach diziler için kullanılır.
       for (int i = 0; i <kurslar.Length; i++) 
        {
            Console.WriteLine(kurslar[i]);   
        
        }
        Console.WriteLine("--------------------For bitti--------------------------");

       //foreach dizilere uygulanır. temelli yapıları tek tek dönmeye yarar. --> kursları tek tek dolaş.
       foreach (string kurs in kurslar) 
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("sayfa sonu - footer");
    }
}

