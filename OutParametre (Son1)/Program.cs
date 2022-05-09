using System;

namespace OutParametre__Son1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yakalananSonuc;
            geriyeDegerDonduren(12, out yakalananSonuc);

            Console.WriteLine(yakalananSonuc.ToString());

            int toplamsonucu;
            int farksonucu;
            long carpimsonucu;
            double bolumsonucu;
            byte modsonucu;

            Hesapla(9, 4,
                out toplamsonucu,
                out farksonucu,
                out carpimsonucu,
                out bolumsonucu,
                out modsonucu);
            Console.WriteLine("toplam:" + toplamsonucu);
            Console.WriteLine("fark" + farksonucu);
            Console.WriteLine("carpim" + carpimsonucu);
            Console.WriteLine("bolum" + bolumsonucu);


        }


        public static void geriyeDegerDonduren(int sayi, out double firlatilanSonuc)
        {
            firlatilanSonuc = Math.Pow(sayi,2);
        }

        //hepsini geriye döndürsün diye out yazıyor.
        public static void Hesapla(int sayiBir,
            int sayıiki,
            out int toplam,
            out int fark,
            out long carpim,
            out double bolum,
            out byte mod)
        {
            toplam = sayiBir + sayıiki;
                fark = sayiBir - sayıiki;
            carpim = sayiBir * sayıiki;
                bolum = sayiBir / sayıiki;
                mod = (byte)(sayiBir % sayıiki);
        }
        //BURAYA KADAR TEK ÖRNEK YUKARISI

    }
}
