using System;

namespace ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek1
            //for(başlangıçDeğeri; BitişKosulu; Artış-Azalışmiktarı)
            //for (int deger = 1; deger < 100; deger++)
            //{
            //    Console.WriteLine(deger);
            //}
            #endregion
            #region örnek2

            //bir ile 10 arasında ki çift sayıları ekrana mod almadan basınız

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region örnek 3

            //Azalma örneği

            //1-10 arası tek sayıları tersten sıralı şekilde ekrana gelsin

            for (int i = 9; i > 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region örnek 4

            // ayın ilk günü pazartesi olarak kabul edildiğinde
            //30 günlük takvimde Pazar günlerini ekrana basın

            for (int i = 0; i < 30; i = i + 7)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region örnek 5

            for (char c = 'A'; c < 'Z'; c++)
            {
                Console.WriteLine(c + "-" + Convert.ToInt32(c));
            }
            #endregion

            #region örnek 6
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("yil:" + DateTime.Now.Year);
            Console.WriteLine("ay:" + DateTime.Now.Month);
            Console.WriteLine("Gün:" + DateTime.Now.Day);
            Console.WriteLine("haftanın kaçıncı günü:" + DateTime.Now.DayOfWeek);
            Console.WriteLine("yılın kaçıncı günü:"+ DateTime.Now.DayOfYear);

            for (int i = 2010; i <= DateTime.Now.Year; i++)
            {
                //Pandemi yıllarını es geçelim 2020-2021
                if (i == 2020 || i == 2021)
                {
                    continue;
                }
                

                    Console.WriteLine(i);


            }

            #endregion
        }
    }
}
