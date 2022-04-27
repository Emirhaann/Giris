using System;

namespace VoidMetodlar
{
    internal class Program
    {
        //geriye değer dönüdmreyen metod
        static void Main(string[] args)
        {
            dersnotları();
            alanhesabı();
            TekCift();
            Console.WriteLine("Hello World!");
            
            //1- 1-100 arasında kş tek ve çift sayıların toplamını yapan metod
            //2- kısa kenar ve uzun kenarın bilgileri ekrandan alacak ve alan ile çevre
            //Hesabı yapacak metodu yazınız.
           
            //3- metod kullanarak vize1. vize2 final notlarını dışarıdan alan ve not ortalamasını 
            //hesaplayan metodu yazınız
        }


        /// <summary>
        /// 1-100 arasında ki sayıların tek, çift toplamını verir.
        /// </summary>
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
        static void alanhesabı()
        {
            //2. ÖRNEK
           // int kısaKenar  , uzunKenar ;
           // Console.WriteLine("Kısa Kenarı Giriniz");
           //kısaKenar= int.Parse (Console.ReadLine());
           // Console.WriteLine("Uzun kenarı giriniz");
           // uzunKenar=int.Parse (Console.ReadLine());
           // Console.WriteLine("Alan:" + (kısaKenar * uzunKenar));
           // Console.WriteLine("Çevre:"+ (2*(kısaKenar+uzunKenar)));          
        }
        static void dersnotları()
        {
            //3.ÖRNEK
            int vize1, vize2, final;
            float ortalama = 0;
            Console.WriteLine("1. Vize notunu giriniz");
            vize1=int.Parse(Console.ReadLine());
            Console.WriteLine("2. vize notunu giriniz");
            vize2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Final Notunu giriniz");
            final = int.Parse(Console.ReadLine());

            ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;
            Console.WriteLine("Not ortalamanız:" + ortalama);
            

        }

    }
}