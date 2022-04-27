using System;

namespace VoidMetodlar
{
    internal class Program
    {
        //geriye değer dönüdmreyen metod
        static void Main(string[] args)
        {
            TekCift();
            Console.WriteLine("Hello World!");
            
            //1- 1-100 arasında kş tek ve çift sayıların toplamını yapan metod
            //2- kısa kenar ve uzun kenarın bilgileri ekrandan alacak ve alan ile çevre
            //Hesabı yapacak metodu yazınız.
           
            //3- metod kullanarak vize1. vize2 final notlarını dışarıdan alan ve not ortalamasını 
            //hesaplayan metodu yazınız

        }
        static void TekCift()
        {
            //1. ÖRNEK
            int tekToplam = 0, ciftToplam = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;
                else
                {
                    tekToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Tek Toplam:" + ciftToplam);

             

        }

    }
}