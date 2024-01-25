using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //MyList : generic classdır. Normal class davranışından bir farkı yoktur.
    //generic class ile çalışacağımız özel bir tip var demek isteriz <T> içine yazacağımız ifade ile.
    public class MyList<T>
    {
        //metot dışında yazdım. direkt class içine yazdım. classın tüm elemanları erişebilir.
        //Add metodunun çalışabilmesi için arka plandaki array'in new gerekmektedir. Fakat items içinde hata verir.
        //Bu newlenebilmeyi gerçekleştirmek için bir classı newlemeliyiz.Buna constructor denir. ctor kısayolu kullan.

        T[] items;
        //Böylece T[] items MyList generic class içinde newleyebiliriz. ve 0 elemanlı bir array oluşturabiliriz.
        //Artık diziye eleman ekleyebilirim.
        public MyList() //Program.cs içinde MyList newlediğim an bu otomatik çalışır. conscructor = class 
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            //New kullandık bir hata alırız çünkü her new yaptığımızda yeni bir ref no oluşur. Bu nedenle o ref birine tuttururuz.
            T[] tempArray = items; //gecici dizinin referansı itemsın ref tutmaktadır demek.
            items = new T[items.Length + 1]; //0 Elemanlı olduğu için array içindeki eleman sayısını 1 arttırmak zorundayız.
            for (int i = 0; i < tempArray.Length; i++) //emanet veriyi geri vermesi için temel mantık.
            {
                items[i] = tempArray[i]; //her bir elemanı items tempArray'in eleman sayısı kadar iade etmesi sağlar bu nedenle eşitledik. add ile gelen son item kaldı.
            }

            //items'ın son elemanı: itemsın uzunluğunun - 1'i çünkü örn 6 elemanımız var fakat index sayısı 0dan başlamaktadır. Bu nedenle bir eksiği olmalıdır 5 olmalıdır.
            items[items.Length - 1] = item; // şimdi aslında eklenmek istenen elemanı ekleyebildim.

        } 
    }
}
