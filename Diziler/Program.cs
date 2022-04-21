using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {     // ilk değer ataması şeklinde dizi tanımı
            string[] sınıftakiler = { "ali", "veli", "ayşe", "fatma" };
            int[] vize1 = { 30, 40, 50, 35 };
            int[] vize2 = { 50, 40, 45, 50 };
            int[] final = { 50, 55, 60, 50 };
            //Ayşeyi ekrana almak istiyoruz
            //ali 0 de veli 1 ayşe 2 de o yüzden alta 2 yazdık ayşeyi verdi. 0 dan başlar.
            Console.WriteLine(sınıftakiler[2]);



            //Ayeşnin 1. vizesi kaçtır
            //vize1 dizisinin 2. elemanı ayşenin vize notudur
            Console.WriteLine(vize1[2]);

            
            
            //ayşenin 2. vize noyu yanlış girilmiş 55 yap
            vize2[2] = 55;


            //sınıftakileri ekrana foreachle yazdıralım
            Console.WriteLine("------foreach-----") ;

            foreach (string ogrenci in sınıftakiler)
            {
                Console.WriteLine(ogrenci);
            }


            //sınıftakileri ekrana for ile yazdıralım
            Console.WriteLine("------for-----");
                for (int i = 0; i < sınıftakiler.Length; i++)
            {
                Console.WriteLine(sınıftakiler[i]);
            }

            Console.WriteLine("------whiledöngüsü-----");
                int sayac = 0;
                while (sayac < sınıftakiler.Length)
            {
                Console.WriteLine(sınıftakiler[sayac]);
                sayac++;
            }

            //kaç kişi olduğunu bilmediğin sınıftakiler dizisinin son elemanını yazın
            Console.WriteLine(sınıftakiler[sınıftakiler.Length - 1]);


            //sınıfın vize ortalamaları nedir
            //1.yol forech

            float ortalama1=0, ortalama2=0;

            foreach (int not in vize1)
            {
                ortalama1 += not;  //ortalama1= ortalama1 + not anlamına gelir
            }
            ortalama1 = ortalama1 / 4;

            foreach (int not in vize2)
            {
                ortalama2 = ortalama2 + not;
            }
            ortalama2 = ortalama2 / 4;

            Console.WriteLine("Birinci vize ortalaması:" + ortalama1);
            Console.WriteLine("ikinci vize ortalaması:" + ortalama2);

            Console.WriteLine("----------------------");



            //2.YOL FOR İLE

            ortalama1 = 0;
            ortalama2 = 0;
            for (int i = 0; i < 4; i++)
            {
                ortalama1 = ortalama1 + vize1[i];
                ortalama2 = ortalama2 + vize2[i];
            }
            ortalama1 = ortalama1 / 4;
            ortalama2 = ortalama2 / 4;
            Console.WriteLine("Birinci vize ortalaması:" + ortalama1);
            Console.WriteLine("ikinci vize ortalaması:" + ortalama2);

            Console.WriteLine("------------------------");


            //SINIFTAKİLERİN TEK TEK VİZE ORTALAMALARI
            int ortalama;
            for (int i = 0; i < sınıftakiler.Length; i++)
            {
                ortalama = (vize1[i] + vize2[i] + final[i]) / 3;
                Console.WriteLine(sınıftakiler[i]+"-"+ ortalama);
            }
            Console.WriteLine("------------------------");

        }
    }
}
