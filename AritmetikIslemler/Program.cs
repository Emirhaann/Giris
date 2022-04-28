using System;

namespace AritmetikIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Matematiksel Islemler

            int sayi1 = 5;
            int sayi2 = 3;
            int sonuc = 0;
            ////Toplamak için 

            //sonuc = sayi1 + sayi2;
            //Console.WriteLine("Toplam :"+sonuc);
            //Console.WriteLine("Toplam :"+sayi1+sayi2); //53 oluyor bu ama parantez olursa 8
            ////yorum satırına almak için ctrl k c 
            //                //çıkartmak için ctrl k u

            //int fark = sayi1 - sayi2;
            //Console.WriteLine("fark :" + fark);
            //Console.WriteLine("fark:" + (sayi1 - sayi2));

            //int çarpım = sayi1 * sayi2;
            //Console.WriteLine("çarpım:" + çarpım);
            //Console.WriteLine("çarpım:" + (sayi1 * sayi2));

            //Console.WriteLine("----------Bölme----------");

            //int bölüm = sayi1 / sayi2;
            //Eğer sonucu küsüratlı görmek istiyorsak, float ya da decimal veri tipine çevirmek gerekir
            float bölüm = sayi1 / Convert.ToSingle(sayi2);
            Console.WriteLine("bölüm:" + bölüm);
            Console.WriteLine("bölüm:" + (sayi1 / sayi2));

            ////0 a bölme hatası
            //sayi2 = 0;
            //if(sayi2==0) // sayi 2 0'a eşit mi anlamında
            //{
            //    Console.WriteLine("bölen sayi 0 olamaz..");
            //}
            //else
            //{
            //    bölüm = sayi1 / sayi2;
            //}

            //Console.WriteLine("-------arttirma--------");

            //Console.WriteLine("sayi:" + sayi1);
            //sayi1 = sayi1 + 1;
            //Console.WriteLine("sayi "+sayi1);

            //sayi1++; //sayi değişkenini1 arttırır 
            //Console.WriteLine("sayi "+sayi1);

            #endregion

            #region Ekrandan değer okuma
            /*
             * ekrandan değer okumak için console.ReadLine() kullanılır
             * bu metod geriye her zaman string döner.
             * sayısal veri almak istiyor isek bu stringi cevirmek (convert lazım). Örnekler aşağıdadır.
             */

            Console.Clear();

            //string input, input2;
            //Console.Clear();

            //Console.WriteLine("Birşeyler giriniz:"); //ekrana mesaj yazaar
            //input= Console.ReadLine(); //Ekrandan mesaj okur.
            //sayi1 = Convert.ToInt32(input);// Girilen değeri integer tipine çevirir.

            //Console.WriteLine("başka birşeyler adha giriniz:");
            //    input2 = Console.ReadLine();
            //sayi2=Convert.ToInt32(input2);

            //Console.WriteLine("Girilen değer:" + input + input2);
            //Console.WriteLine("Girilenlerin Toplamı:" + (sayi1 + sayi2));

            //#endregion
            ////Soru1: Dışarıdan alınan 2 sayının toplamıyla, farkının birbirlerine bölümünden kalanınsonucu kaçtır
            ////soru 2 farkın toplama bölümünden kalan kaçtır

            //ÇALIŞIRKEN YAPTIM
            //int sayı1; int sayı2; 
            //Console.WriteLine("1. Sayıyı giriniz");
            //sayı1=int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı giriniz");
            //sayı2=int.Parse(Console.ReadLine());
            //Console.WriteLine("toplam fark bölümleri:" + (sayı1 + sayı2)/(sayı1-sayı2));

            //string input = "";
            //Console.WriteLine("1.sayıyı giriniz");
            //input = Console.ReadLine(); 
            //sayi1 = Convert.ToInt32(input);

            //Console.WriteLine("2. sayıyı giriniz");
            //input = Console.ReadLine(); 
            //sayi2 = Convert.ToInt32(input);

            //float toplam = sayi1 + sayi2;
            //float Fark = sayi1 - sayi2;
            //float bolumkalan = toplam % fark;
            //Console.WriteLine("sonuc:" +bolumkalan);
            //Console.WriteLine("farkın toplama bölümünden kalan:" + (fark % toplam));


            #endregion

            #region
            //Dışardan girilen sayının 10 eksiğinin 20 fazlasının 2 ye bölümünden kalanın karesi kaçtır

            //Console.WriteLine("sayı giriniz");
            //input = Console.ReadLine();
            //sayi1 = int.Parse(input);
            //sayi1 = sayi1 - 10;
            //sayi1 = sayi1 + 20;
            //sayi1 = sayi1 % 2;
            //Console.WriteLine("sonuç" + sayi1*sayi1);

            #endregion

            #region
            //dışarıdan girilen 2 sayının kareleri toplamı ile kareleri farkı kaçtır
            //Console.WriteLine("1. sayıyı giriniz.");
            //string input = Console.ReadLine();
            //sayi1 = int.Parse(input);
            //Console.WriteLine("2.sayıyı giriniz.");
            //input = Console.ReadLine();
            //sayi2= int.Parse(input);

            //int karetoplam, karefark;
            //    karetoplam = sayi1 * sayi1 + sayi2 * sayi2;
            //karefark = sayi1 * sayi1 - sayi2 * sayi2;

            //Console.WriteLine("karetoplam:"+ karetoplam);
            //Console.WriteLine("karefark:"+ karefark);



            #endregion

            #region
            //2 vize %30 1 final not %70 ile öğrencinin not ortalamasını bulunuz
            //notlar 10dalıklı olainilir

            //float vize1, vize2, final, ortalama;

            //Console.Write("1. vize.");
            //vize1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("2.vize:");
            //vize2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("final");
            //final = float.Parse(Console.ReadLine());

            //ortalama = (vize1 + vize2) / 2 * 30 / 100 + final * 70 / 100;

            //Console.WriteLine("Not ortalamanız:" + ortalama);

            #endregion

            #region
            //dışarıdan girilen ad soy ad bilgilerini alarak aaaa@hotmail.com oluştur

            //BENİM ÖRNEK
            //string ad, soyad, email;

            //Console.WriteLine("Adınızı giriniz.");
            //ad=Console.ReadLine();
            //Console.WriteLine("Soy adınızı giriniz");
            //soyad=Console.ReadLine();
            //Console.WriteLine("Mail adresiniz:" + ad + soyad + "@hotmail.com");



            //string ad, soyad, email;

            //Console.WriteLine("adınızı giriniz");
            //ad = Console.ReadLine();

            //Console.WriteLine("soy adınızı giriniz");
            //soyad= Console.ReadLine();

            //email= ad + "."+ soyad + "@gmail.com";

            //Console.WriteLine("mailiniz:"+ email);

            #endregion



            #region
            //dışarıdan girilen 2 sayının bölümünü ondalıklı olarak ekrana yazınız 
            //dikkat bölen 0 olmayacak ifle yapılıcak.

            //Console.WriteLine("1.sayıyı giriniz");
            //string input = Console.ReadLine();
            //sayi1 = int.Parse(input);

            //Console.WriteLine("2.sayıyı giriniz");
            //input = Console.ReadLine();
            //sayi2 = int.Parse(input);

            //if (sayi2 != 0) ;
            //{
            //    float bolum = sayi1 / (float)sayi2;
            //    Console.WriteLine("sonuç=" + bolum);
            //}

            #endregion
        }
    }
}