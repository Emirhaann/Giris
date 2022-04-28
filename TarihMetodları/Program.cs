using System;

namespace TarihMetodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime baslangic= DateTime.Now;
            // Günün tarih ve zamanı almak
            Console.WriteLine(DateTime.Now);

            //Sadece gün.ay.yıl verir
            Console.WriteLine(DateTime.Now.ToShortDateString());

            //tarih ve saat ile gün ismide verir
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            //Tarihi formatlamak
            Console.WriteLine(DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime
                .Now.Year);

            //Artık Yıl kontrolü
            bool artikYilmi = DateTime.IsLeapYear(2022);
            Console.WriteLine();

            //SORU: SON 10 yılın artık yılları hangileridir bulunuz.
            for (int i = 2000; i < DateTime.Now.Year; i++)
            {
                artikYilmi=DateTime.IsLeapYear(i);
                if(artikYilmi)
                    Console.WriteLine(i);
            }

            //Haftanın günü
            Console.WriteLine(DateTime.Now.DayOfWeek);

            //yılın günü
            Console.WriteLine(DateTime.Now.DayOfYear);

            DateTime bora = new DateTime(1994, 9, 13);
            DateTime simdi = DateTime.Now;

            TimeSpan tarihFarki = simdi - bora;
            Console.WriteLine("Bora" + tarihFarki.Days + "Gündür Hayatta");
            Console.WriteLine("Bora" + tarihFarki.TotalHours + "Saattir");

            DateTime bitis = DateTime.Now;
            tarihFarki = bitis - baslangic;

            
        }
    }
}
