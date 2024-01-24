using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 : 30 olur Neden?
            // sayi1 30da kalır.
            //int-decimal-float-double-bool = değer tiptir
            //Bellekte stack ve heap alanlar vardır.
            //Bir değişken tanımladığımızda
            //örn int türünde bir dğişken tanımlarsak bu "Değer Tip olanlar --> STACK" alanında gerçekleşir.
            // sayi1'in değeri eşittir 10, sayi2'nin degeri eşittir 30 diye okuruz.
            //sayi1 = sayi2 --> STACK BÖLGESİNDE sayi1'in değeri eşittir sayi2'nin değeri şeklinde okuruz.  
            //Sadece değeri aktarırız, sayı2 ile olan bütün irtibat kopar. YANİ 30 ATANMIŞ OLUR.
            //Ardından yaptığımız sayı2 atamasının bir anlamı yoktur. 
            //sayi1 = sayi2 sayı2 kopyalar ardından atanan sayı önemsiz. değer tip olduğu için.

            //------------------------------------------------------------------------
            int[] sayilar1 = new int[] { 10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? sonuc ne olur? neden?
            //cevap: 999
            //array[], class, interface = referans tiptir
            //Bellekte stack ve heap alanlar vardır.
            //sayilar1[] bir int arraydir ve arraylar referans tiptir.
            //sayilar1[] stack alanındadır "New" ile Heap alanında yeni bir alan açarız. Bu alanı 101 referans no ile tutarız. 
            //Heap: Referans No açmamızı sağlar.
            //sayilar2[] newlediğimde yeni bir referans no oluşur bunun nosu 102 olsun.
            //sayilar1 = sayilar2 okunusu --> sayilar1'in referans nosu eşittir sayilar2'nin referans nosuna
            //artık sayılar1 = 102 nolu referans no tutmaya baslar. 101 ile tum ilişik kesilir.
            //sayılar2 0. indisine yeni bir sayı atamasını yaptığımızda 102 ref nolu alanda değişim olmaktadır.
            //Bu nedenle sayilar1'in [0] : 999 olur çünkü sayılar1[0] artık 102 referans nosunu temsil eder.
            //101'i tutan kimse yok .net'in garbage collector ile bellekten atar.


            Console.WriteLine(sayi1);
        }
    }
}



