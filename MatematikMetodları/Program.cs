using System;

namespace MatematikMetodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pİ sayisi
            Console.WriteLine(Math.PI);

            //Mutlak değer  ABS
            Console.WriteLine(Math.Abs(-27));

            //yuvarlama: Floor => verilen sayıyı bir alt tam değere yuvarlar
            Console.WriteLine(Math.Floor(12.9));

            //ceiling => verilen sayıyı bir üst tam sayıya yuvarlar
            Console.WriteLine(Math.Ceiling(12.1));

            //Round=> verilen sayının yarıdan fazlası ise yukarı
            //yarıdan azı ise aşağı
            Console.WriteLine(Math.Round(12.55));
            Console.WriteLine(Math.Round(12.45));
            //sayı çift ve yarımsa yanş 12.50 ise 12 ye -- 13.50 ise yukarı yuvarlar

            //Truncate=> Sayının tam kısmını alır virgülden sonrasına bakmaz
            Console.WriteLine(Math.Truncate(22.50));

            //Max value
            Console.WriteLine(Math.Max(12,45));

            //Min value
            Console.WriteLine(Math.Max(12, 45));
        }
    }
}
