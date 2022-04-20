using System;

namespace WhileDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sayac = 0;
            //while (sayac < 10)
            //{
            //    Console.WriteLine("hello World");
            //    sayac++;    
            //}

            //1-100 arası sayıları topla

            //int toplam = 0;
            //while (sayac <= 100)
            //{
            //    toplam = toplam + sayac;
            //    sayac++;
            //}
            //Console.WriteLine("sonuc:" + toplam);

            #region
            //0-100 arasıdnda ki çift ve tek sayıların toplamı

            int tekToplam = 0, ciftToplam = 0;
            while (sayac < 100)
            {
                if (sayac % 2 == 0)
                {
                    ciftToplam += sayac;
                }
                else
                {
                    tekToplam += sayac;
                }
                sayac++;    
               
            }
            Console.WriteLine("Tek Toplam :"+tekToplam);
            Console.WriteLine("Tek Toplam :"+ciftToplam);
            #endregion


        }
    }
}
