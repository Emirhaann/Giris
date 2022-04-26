using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, };
            
            ArrayList cuval = new ArrayList();
            cuval.Add("Ali");
            cuval.Add(12);

            List<string> sehirler = new List<string>();
            sehirler.Add("Adana");
            sehirler.Add("Urfa");
            sehirler.Add("Bursa");

            List<int> sayilar = new List<int>();

            Console.WriteLine("Kaç eleman gireceksiniz:");
            int elemansayisi = int.Parse(Console.ReadLine());

            //Bu döngü girilen eleman sayisi kadar veri ekler
            Random rnd = new Random();

            int tekSayi = 0, ciftSayi = 0, geçici = 0;
            for (int i = 0; i < elemansayisi; i++)
            {
                geçici = rnd.Next(1, 50);
                if (geçici % 2 == 0)
                    ciftSayi++;
                else
                    tekSayi++;

                sayilar.Add(geçici);

            }
            Console.WriteLine("Tek sayi adedi:" + tekSayi);
            Console.WriteLine("cift sayi adedi:"+ ciftSayi);
            #region Örnek1
            /*
             * 1- Bir sınıftaki kişilerin ad ve soyadlarını tutan listeyi yazınız
             * 2- Aynı sınıfın vize ve final notlarını tutacak listeyi yazınız
             * 3- sınıftakilerin geçip kalma durumlarını hesaplayınız
             */
            List<string> siniflistesi = new();
            List<int> vize1 = new();
            List<int> vize2 = new();
            List<int> final = new();
            List<float> sonuclar= new();
            
            //sınıf listesi oluşturuluyor.
            siniflistesi.Add("ali");
            siniflistesi.Add("veli");
            siniflistesi.Add("ayse");
            siniflistesi.Add("fatma");
            //vize notları giriliyor
            vize1.Add(40);
            vize1.Add(45);
            vize1.Add(50);
            vize1.Add(55);
            //vize2 notları giriliyor
            vize2.Add(40);
            vize2.Add(50);
            vize2.Add(55);
            vize2.Add(60);
            //final notları giriliyor
            final.Add(50);
            final.Add(50);
            final.Add(50);
            final.Add(50);
            float not = 0;
            
            //geçip kalma notları hesaplanıyor
            for (int i = 0; i < vize1.Count; i++)
            {
                not = (vize1[i] + vize2[i]) / 2 * 0.3f + final[i] * 0.7f;
                sonuclar.Add(not);
            }
            
            for (int i = 0; i < sonuclar.Count; i++)
            {
                Console.WriteLine(siniflistesi[i] + "Geçme Notu:" + sonuclar[i]);
            }
            #endregion
        }
    }
}
