using System;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek1
            int sayac = 0;
            //do
            //{
            //    Console.WriteLine("Ali veli");
            //    sayac++;
            //} while (sayac <= 10);

            //1-100 arasında ki tek çift toplamları bul


            int tektoplam = 0, cifttoplam = 0;
            sayac = 0;

            do
            {
                if (sayac % 2 == 0)
                {
                    cifttoplam += sayac;
                }
                else
                {
                    tektoplam += sayac;
                }
                sayac++;
            } while (sayac < 100);
            Console.WriteLine("Tek toplamlar:" + tektoplam);
            Console.WriteLine("cift toplamlar:"+ cifttoplam);

            //cevabı yazıyo soruyu istiyo

            int a=1, b = 5;
           
            do
            {
                a = a * b;
                b--;
            } while (b > 0);
            Console.WriteLine("sonuc:" + a); ;
            #endregion
        }
    }
}
