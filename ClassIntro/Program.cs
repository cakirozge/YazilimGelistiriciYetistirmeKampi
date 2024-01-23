using System;
namespace KampIntro;

class Program
{
    //NEDEN CLASS KULLANIRIZ?
    //Bir veri tek bir bilgi taşımaz.
    //İnceledğimiz kodlama.io web sitesinde kursun bir ismi, bir resmi, eğitmen ismi, eğitmen resmi, tamamlama oranı gibi bilgiler içerir.
    //Bu e-ticaret sistemlerinde değişiklik gösterir.
    static void Main(string[] args)
    {
        string adi = "Engin";
        int yas = 36;

        //Böyle bir değişken tanımlayabilmek için bir class oluşturmalısın.
        //Kendi veri tipini yazıyorsun gibi düşün.
        //Kurs değişkeni tanımlamasıdır. (benim artık kurs1im var tipi de kurstur.)
        //Classın değişkenlerini atadığımız hareket budur.
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demirog";
        kurs1.IzlenmeOranı = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlenmeOranı = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOranı = 80;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++ ";
        kurs4.Egitmen = "Murat Kurtboğan";
        kurs4.IzlenmeOranı = 100;

        Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};

        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen + ", İzlenme Oranı: " + kurs.IzlenmeOranı + "%");
        }

        //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOranı);

    }

    //Class tanımlaması
    class Kurs
    {
        //prop: özelllik ve bu kursun özellikleri
        //kurs objeleri
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }







}
