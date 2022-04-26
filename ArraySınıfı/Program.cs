using System;

namespace ArraySınıfı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // string[] arabalar = { "Bmw", "Audi", "Fiyat", "Toyota", "Honda", "AlfaRomeo", "Subaru" };
            // Console.WriteLine("aradığınız araç ?");
            // string arananaraba =Console.ReadLine();
            // int index = Array.IndexOf(arabalar, arananaraba);
            // // 1. parametre kaynak dizi
            // //2. parametre aranacak olan değer burada tip önemli
            // if (index == -1)
            // {
            //     Console.WriteLine("Aradığınız" + arananaraba + "Listede yoktur");
            // }
            // else
            // {
            //     Console.WriteLine("Aradığınız" + arananaraba + " " + index + ". sıradadır");
            // }
            //index = Array.IndexOf(arabalar, arananaraba, 2);
            // //Burada arama işlemi 2. indexten başlayacaktır.
            #endregion

            #region Array.reverse 
            // bu metod diziyi tersine çevirir. Sıralama yapmaz
            string[] arabalar = { "Bmw", "Audi", "Fiyat", "Toyota", "Honda", "AlfaRomeo", "Subaru" };
        int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        
        Array.Reverse(arabalar);
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        #endregion
        }
       

    }
}
