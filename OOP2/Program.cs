using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "000001";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "333333";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";



            Musteri musteri3 = new GercekMusteri(); //bellekteki ref no diye okuma yap. Musteri class ı hem gerçek m/ tuzel m ref tutabilmektedir.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            
           
        }
    }
}

//sirketadi bizimle ilgili değil hatalıdır.

//Gerçek-Tüzel: İkiside müşteri sırf birbirine benziyor diye birbirinin yerine kullanılamazlar. Farklı  müşteri tipidir.
//SOLID - L Harfi söyler.