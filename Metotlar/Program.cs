using Metotlar;
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //urun tanımlamak için yazarız buna class'ın örneği denir.
            //bu bir class olduğu için bu şekilde yazmak zorundayız. Tanımlamaları gerçekleştirdik.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;
            urun1.StokAdedi= 10;    

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 20;   

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //in urunler : urunler dizimin her bir elemanını tek tek gez gelen datayı tek tek ekrana basar.
            //Urun urun: urun--> takma isim arka planda dönerken verdiğimiz isim
            //Urun: veri tipi C# TYPE SAFEdir.
            //Var: kabul edilebilir.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + ", " + urun.Aciklama + ", " + urun.Fiyati + ", Stok : " + urun.StokAdedi);
            }

            Console.WriteLine("--------------------Metotlar------------------------");

            //bu bir class örneğidir -- instancedır.
            SepetManager sepetManager = new SepetManager();
            //metot bu şekilde çağırılır.
            //Ne ekleyeceğini bilmek ister parametre verdiğimiz için. Neyi göstermek istiyorsak onu eklemeliyiz.
            //encapsulation -- sepetManager değişiklik yaptık ve ekle metotlarımızda hiçbir değişiklik meydana gelmedi buna encapsulation denir.
            //ayrı ayrı ve düzensiz yapıları bir düzen içine yani bir kapsül içine getiriyoruz.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //hatalı kullanım örneği:
            sepetManager.Ekle2("Etek", "Giysi", 10, 6);
            sepetManager.Ekle2("Ayakkabı", "Outdoor", 150, 9);
            sepetManager.Ekle2("Gözlük", "Okuma gözlüğü", 50,8);

        }
    }
}





//Dont repeat yourself- DRY