using System;

namespace HazirMetodlar
{
    internal class Program
    {
        //sahip olduğunuz metinsel değerlerin özelliklerini değiştirmek için kullanılan metodlar
        static void Main(string[] args)
        {
            //OrnekCompare();
            //OrnekStartWith();
            //OrnekIndexOf();
            //OrnekRemove();
            //ornekReplace();
            //ornekSplit();
            //OrnekInsert();
            //ornekToUpperToLower();
            //OrnekToCharArray();
            //OrnekTrim();
            //OrnekSubString();
        }

        private static void OrnekSubString()
        {
            //seçtiğiniz belirli bir kısmı çekip almanıza yarar

            string ornekMetin = "Bu gün hava çok güzel";
            string yeniMetin = ornekMetin.Substring(5);
            Console.WriteLine(yeniMetin);
            //2. Kullanımı 
            Console.WriteLine(ornekMetin.Substring(6, 4));
            
        }

        private static void OrnekTrim()
        {
            //Boşlukları siler trim
            string ornekMetin = "Bugun hava çok guzel";
            Console.WriteLine(ornekMetin.Trim());
            
        }

        private static void OrnekToCharArray()
        {
            string ornekMetin = "Bugun hava çok guzel";
            char[] harfler = ornekMetin.ToCharArray();
            foreach (var harf in harfler)
            {
                Console.WriteLine(harf);
            }
        }

        private static void ornekToUpperToLower()
        {
            string ornekMetin = "Bugun hava çok guzel";
            Console.WriteLine(ornekMetin.ToLower());
            Console.WriteLine(ornekMetin.ToUpper());
        }

        private static void OrnekInsert()
        {
            //Insert= bir metnin herhangi bir yerine yeni bir şey iliştirmek için kullanılır.

            string ornekMetin = "bugün hava çok güzel";
            string yeniMetin = ornekMetin.Insert(10, "çok");
            Console.WriteLine(yeniMetin);
        }

        private static void ornekSplit()
        {
            //replace= metnin içerisindeki bir karakteri ya da bir bölümü yeni bir  
            //karakter-bölüm ile değiştirmenize olanak sağlar.
            string ornekMetin = "Haberler, son dakika haberleri ve güncel, en son haber " +
                "başlıkları için Habertürk! Gazete haberleri, yeni" +
                " gelişmeler ve spor, magazin, gündem, ekonomi haberi ...";

                string[] cumleler = ornekMetin.Split('.');
            foreach (string cumle in cumleler)
            {
                string[] kelimeler = cumle.Split(" ");
                Console.WriteLine(cumle);

                foreach (string kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }
            }
        }

        private static void ornekReplace()
        {
            string ornekMetin = "bugun hava çok guzel";
            string yenimetin = ornekMetin.Replace("guzel", "berbat");
            Console.WriteLine(ornekMetin);
            Console.WriteLine(yenimetin);
        }

        private static void OrnekRemove()
        {
            // yaptığını değişiklikleri silmez kopyasını verir verdiğiniz index numarası dahil
            //onu ve devamını komple siler 
            string ornekMetin = "Bu gün hava çok güzel";
            string yenimetin = ornekMetin.Remove(5);
            Console.WriteLine(ornekMetin);   
            Console.WriteLine(yenimetin);
            yenimetin = ornekMetin.Remove(5, 5);
            Console.WriteLine(yenimetin);
        }

        private static void OrnekIndexOf()
        {
            //IndexOf0=> dizilerde gördüğümüz metodun aynı prensibiyle çalışır
            //Eğer harf varsa harfin indexini  yoksa -1 değerini harf 1 den fazlasya ilk harfin indexini
            //dondurur. saymaya 0 dan başlar 
            string ornekMetin = "Bu gün  hava çok güzel";
            int index = ornekMetin.IndexOf('a');
            Console.WriteLine("index numarasi:"+index);
            index = ornekMetin.LastIndexOf('a');
            Console.WriteLine("Lastindex numarasi:" + index);
        }

        public static void OrnekStartWith()
        {
            string ornekMetin = Console.ReadLine();
            bool sonuc = ornekMetin.StartsWith("bil");
            if (sonuc)
            {
                Console.WriteLine("cümle bil ile başlamaktadır");
            }
            else
            {
                Console.WriteLine("cümle bil ile başlamamaktadır.");
            }
        }

        private static void OrnekCompare()
        {
            string ornekMetin = Console.ReadLine();
            int sonuc = ornekMetin.CompareTo("emirhan");

            string mesaj = "";
            switch (sonuc)
            {
                case -1:
                    mesaj = "kelime diğer kelime ile eşleşmektedir." + "Eksik karakter var";
                    break;
                case 0:
                    mesaj = "Tebrikler! kelimeler eşleşmektedir";
                    break;
                case 1:
                    mesaj = "kelime diğer kelime ile eşleşmemektedir. Fazla karakter var";
                    break;
                default:
                    break;
            }
            Console.WriteLine(mesaj);
        }
    }
}
