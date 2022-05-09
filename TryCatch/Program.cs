using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            int sayi1, sayi2;
            float sonuç;

            try
            {
                Console.Write("1.sayıyı giriniz");
                sayi1 = int.Parse(Console.ReadLine());

                Console.Write("2.sayıyı giriniz");
                sayi2 = int.Parse(Console.ReadLine());
           
               sonuç = sayi1 / (float)sayi2;
                Console.WriteLine("sonuç:" + sonuç);

            }

            catch (Exception ex)
            {
                Console.WriteLine("hata oluştu:" + ex.Message);


                #endregion



                #region


                DateTime dogumTarihi;
                string input;
                try
                {
                    Console.Write("Doğum tarihi giriniz.");
                    input = Console.ReadLine();
                    dogumTarihi = DateTime.Parse(input);
                    Console.WriteLine("doğum tarihiniz:" + dogumTarihi.ToString());

                }
                catch (Exception Ex)
                {
                    
                    Console.WriteLine(ex.Message);
                 
                }


                #endregion
            }
        }
    }
}