 using System;

namespace ParametreliMetodlar
{
    internal class Program
    {
        //dışarıdan gelecek olan değerelere göre işlem değişerecek olan metodlar
        static void Main(string[] args)
        {
            AsalSayi();
            EkranaYazdir("Naber gülüm");
            Console.WriteLine("Hello World!");
            sesliHarfSayisi("şemsi paşa pasajında sesi büzülesiceler");
            //verilen kelimeyi harf harf ekrana bastıran metod
            //verilen string içerisinde ki Türkçe harflerin sayısını bulan metod
            
            //1- Rastgele şifre üreten metod yazın
            // en az 1 tane büyük harf, en az 1 sayı olacak
            //en az 8 karakter olacak 

            //2- Verilen sayının asal sayı olup olmadığını belirleyen metod
        }
        /// <summary>
        /// verilen intdeğerleri toplar
        /// </summary>
        /// <param name="sayi1">int tipinde</param>
        /// <param name="sayi2">int tipinde</param>
        /// <returns>int tipinde</returns>
        public static int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        /// <summary>
        /// 3 lü parametre mesela intler paramtre
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <param name="sayi3"></param>
        /// <returns></returns>
        public static int topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        public static int topla(params int[] parametreler)
        {
            int toplam = 0;
            foreach (var item in parametreler)
            {
                toplam += item;
            }
            return toplam;
        }

        public static void sesliHarfSayisi(string cumle)
        {
            // türkçe harfler : ç,ö,ü,ş,ğ,ı
            char[] turkceHarf = {'ç','ı','ğ','ş','ö','ü'};
            int[] turkceHarfSayısı = { 0, 0, 0, 0, 0, 0 };

            foreach (char harf in cumle)
            {
                if (harf == 'ç')
                    turkceHarfSayısı[0]++;
                if (harf == 'ı')
                    turkceHarfSayısı[1]++;
                if (harf == 'ğ')
                    turkceHarfSayısı[2]++;
                if (harf == 'ş')
                    turkceHarfSayısı[4]++;
                if (harf == 'ü')
                    turkceHarfSayısı[5]++;

            }
            for (int i = 0; i < turkceHarfSayısı.Length; i++)
            {
                Console.WriteLine(turkceHarf[i] + ":" + turkceHarfSayısı[i]);
            }
        }

        static void EkranaYazdir(string mesaj)
        {
            foreach (char harf in mesaj)
            {
                Console.WriteLine(harf);
            }
        }

        static void AsalSayi()
        { 
            //2 NUMARALI ÖRNEK
            //YANLIŞMIŞ!!!

            int sayı;
            Console.Write("Bir sayı giriniz");
            sayı = int.Parse(Console.ReadLine());
            
            if ( sayı % 2 != 0)
            {
                Console.WriteLine("Girdiğiniz Sayı Asal Sayıdır");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir");
            }
        }
    }
}
