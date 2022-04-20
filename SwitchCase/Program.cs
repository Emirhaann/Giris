using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plaka = "";
            Console.WriteLine("plaka kodunu giriniz");
            plaka= Console.ReadLine();

            if (plaka == "1" || plaka == "01")
            {
                Console.WriteLine("Adana");
            }
            else if (plaka == "2" || plaka == "02")
            {
                Console.WriteLine("Adıyaman");
            }
            else if (plaka == "3" || plaka == "03")
            {
                Console.WriteLine("Afyon");
            }

            switch (plaka)
            {
                case "1":
                    Console.WriteLine("Adana");
                    break;
                case "2":
                    Console.WriteLine("Adıyaman");
                    break;
                case "3":
                    Console.WriteLine("Afyon");
                    break;
                default:
                    break;
            }


        }
    }
}
