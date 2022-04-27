using System;

namespace MetodGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(3, 5);
            Console.WriteLine(toplam);
            Console.WriteLine(topla("Ali  "," veli"));
            EkranaYaz("asdgasdga");
            Console.WriteLine("Hello World!");
        }
        // bütün metodlar class içerisinde olmak zorunda
        //Aşağıdaki metodun geri dönüş tipi intdeğer, aldığı 2 adet paratmerre var 2side integer

        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        //AŞağıdaki metodun ismi yukarıdakiyle aynı olmasıan rağmen
        //aldığı parametreler farklı olduğundan hata vermez.
        //buna metod overloading denir.
        public static float Topla(float sayi1, int sayi2)
        {
            return ((sayi1 + sayi2));
        }
        /// <summary>
        /// verilen 2 adet string'i birleştirir.
        /// </summary>
        /// <param name="a">string tipinden ilk değer</param>
        /// <param name="b">string tipinden ikinci değer</param>
        /// <returns>iki stringi birleştirip geri döner</returns>
        public static string topla(string a, string b)
        {
            return a + b;
        }
        public static decimal Topla(decimal sayi1, int sayi2)
        {
            return ((sayi1 + sayi2));
        }
        /// <summary>
        /// verilen string tipinden mesajı consola yazar.
        /// </summary>
        /// <param name="mesaj">string tipinden mesaj</param>
        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

    }    
        

}
