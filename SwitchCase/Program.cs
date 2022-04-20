using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek1
            //string plaka = "";
            //Console.WriteLine("plaka kodunu giriniz");
            //plaka = Console.ReadLine();

            //if (plaka == "1" || plaka == "01")
            //{
            //    Console.WriteLine("Adana");
            //}
            //else if (plaka == "2" || plaka == "02")
            //{
            //    Console.WriteLine("Adıyaman");
            //}
            //else if (plaka == "3" || plaka == "03")
            //{
            //    Console.WriteLine("Afyon");
            //}

            //switch (plaka)
            //{
            //    case "1":
            //        Console.WriteLine("Adana");
            //        break;
            //    case "2":
            //        Console.WriteLine("Adıyaman");
            //        break;
            //    case "3":
            //        Console.WriteLine("Afyon");
            //        break;
            //    default:
            //        break;
            //}

            //Console.WriteLine("kullanıcı:");
            //string kullanıcı = Console.ReadLine();
            
            //switch (kullanıcı)
            //{
            //    case "Admin" or "admin":
            //        Console.WriteLine("yönetim paneline yönlendiriliyorsunız");
            //        break;
            //    default:
            //        break;

            //}


            #endregion


            #region örnek 2

            Console.WriteLine("Kullanici adi giriniz");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("parola giriniz");
            string parola = Console.ReadLine();

            switch (kullaniciAdi)
            {
                case "bilgeadam":
                    switch (parola)
                    {
                        case "1234":
                            Console.WriteLine("kullanici adi ve parola doğrudur");
                            break;
                        default:
                            Console.WriteLine("kullanıcı adı doğru parola yanlış");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Kullanici adi dogru, parola yanlış");
                    break;
            }
            #endregion

        }
    }
}     