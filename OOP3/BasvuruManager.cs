using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {
        //bir kredi hesaplıyor.
        //Metot injection yapıyoruz.
        //Yani BaşvuruYap metodunun kullanacağı kredi managerın ne olacağını -tür, ve hangi loglayıcı olacagını enjekte ediyoruz.
        //Loglama birkaç alternatifle sunulabilir. Hem veritabanına hem de sana sms gönderebilir.
        //tek tek gönderir.
        public void BasvuruYap(IKrediManager krediManager,  List<ILoggerService> loggerServices)
        {
            //BASVURAN BİLGİLERİNİ DEĞERLENDİRME
            //

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        
        //herbir kredi için hesaplama yapıyor. List<> kullandık foreach ile list içinde dolaşabildik.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

     
    }
}
