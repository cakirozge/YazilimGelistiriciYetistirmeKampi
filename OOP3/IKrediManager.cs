using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface şablonumuzdur.
    //Biri bu interface i kullanırsa şu metodu içermek zorundadır.
    //Kuralları içeirir. classlarda kullanmak istersen implemente etmeyi unutma.
    //Bu interfacei implemente eden classlar bu interface içinde geçen kuralları kendine göre uygulamak zorundadır.
    //bizim için ref tutsun ve tüm kredi tipleri zorunlu kullanabilsin dite IKredi manager kullanıyoruz.
    //Alternatif senaryolar için şablon oluşturuyoruz.
    //** Interface: Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    public interface IKrediManager
    {
        //hER KREDİDE ZORUNLU VE HER BİR KRDİ BUNLARI İÇERMEK ZORUNDA
        void Hesapla();
        void BiseyYap();
       
    }
}

//Loglama: Kim ne zaman hangi operasyonu çağırdı bilgilerini tutan bir dökümdür.