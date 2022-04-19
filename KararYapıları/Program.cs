using System;

namespace KararYapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1
            //string kod;
            //Console.WriteLine("içecek kodunu girini");
            //kod= Console.ReadLine();

            //if (kod == "Ç" || kod=="ç")
            //{
            //    Console.WriteLine("Çay");
            //}
            //else if (kod =="M" || kod=="m")
            //{
            //    Console.WriteLine("Meyve Suyu");

            //}
            //else if (kod =="L" || kod=="l")
            //{
            //    Console.WriteLine("Limonata");

            //}
            //else
            //{
            //    Console.WriteLine("girilen kod çözülemedi");
            //}
            #endregion 


            #region örnek 2
            //Ekrandan kullanıcı adı ve parola alınacak
            //doğru ise hoşgeldiniz desin
            //diğer türlü hangisinin hatalı olduğunu ekrana yazdsın
            //kullanıcı adı: admin parola: asdfasd

            string kullanıcıadı, parola;

            //Console.WriteLine("kullanıcı adı giriniz");
            //kullanıcıadı= Console.ReadLine();

            //Console.WriteLine("parolanızı giriniz");
            //parola= Console.ReadLine();

            //if (kullanıcıadı == "Admin" && parola == "qweasd")
            //{
            //    Console.WriteLine("Hoşgeldin sahip..");
            //}
            //else
            //{
            //    Console.WriteLine("lütfen geçerli bir kullanıcı adı veya şifre giriniz");

            //    //DETAYLI BİLGİ İÇİN
            //    //bi dene ad doğru şifre yanlış vs
            //}

            #endregion



            #region örnek 3

            // kod doğru şifre doğru
            // kod doğru şifre yanlış
            // kod yanlış şifre doğru
            // kod yanlış şifre yanlış
            //string kullanıcıadı, parola;

            Console.WriteLine("kullanıcı adı giriniz");
            kullanıcıadı = Console.ReadLine();

            Console.WriteLine("parolanızı giriniz");
            parola = Console.ReadLine();

            if (kullanıcıadı == "Admin" && parola == "qweasd")
            {
                Console.WriteLine("hoşgeldiniz sahip..");
            }

            else if (kullanıcıadı == "Admin" && parola != "qweasd")
            {
                Console.WriteLine("kullanıcıadı doğru şifre yanlış");
            }
            #endregion


            #region örnek 4


            //Girilen not 0-30 arasında ise FF
            //30-50 ise dd 
            //50-70 ise bb
            //70-100 ise aa

            Console.WriteLine("Bir not giriniz");

            int not = int.Parse(Console.ReadLine());


            if (not >= 0 && not <= 30)
            {
                Console.WriteLine("FF notu aldınız");

            }


            else if (not >= 30 && not <= 50)
            {
                Console.WriteLine("DD harf notu aldınız");

            }

            else if (not >= 70 && not <= 100)
            {
                Console.WriteLine("AA notu ile geçtiniz");

            }
            else
            {

                Console.WriteLine("Böyle bir not yok");
                #endregion

            #region örnek 5
                //dışarıdan ürün adı girilecek kasiye bize ürünün hangi reyondan olduğunu söyelecek
                //domates biber patlucan= sebze
                //,diş macunu parfüm şampuan= kozmatik
                //cep telefonu bilgisayar ses sistemi= teknoloji reyonu
                //başka bir ürün girilise bu ürün bizde yok denicek


                string input;

                Console.WriteLine("Ne arıyorsunuz:");
                input = Console.ReadLine();

                if (input == "Domates" || input == "biber" || input == "patlıcan")
                {
                    Console.WriteLine("ürününüz sebze reyonuna ait");
                }
                else if (input == "diş macunu" || input == "parfüm" || input == "şampuan")
                {
                    Console.WriteLine("ürününüz kozmatik reyouna ait");
                }
                else if (input == "ceptelefonu" || input == "bilgisayar" || input == "sessistemi")
                {
                    Console.WriteLine("Ürününüz teknoloji reyonuna ait");
                }

                else
                {
                    Console.WriteLine("böyle bir ürün yok");
                }


                #endregion

                #region örnek 6

                //dışarıdan sipariş alınacak olan kitap miktarı girilsin
                //sipariş sayısı 20 den azsa toplam ücretten %5
                //20 50 arasında ise %10 50-100 arasındda ise %15
                //100 den fazla ise %25 indirim yapılsın
                //kitap 5 tl
                // ne kadar ödemesi lazım göster

                #endregion


                #region örnek 7

                //kullanıcıdan 2 sayı al
                // ekrana[+,-,*,]
                //hangisini girdiyse ona göre işlem yapsın
                #endregion


                #region örnek 8
                // ekrana girilen mevsime göre ayları yazın
                #endregion





            }

        }

    }
}