using System;

namespace ŞansOyunları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ekrandan deneme sayısı alınacak
             * deneme sayısı kadar bir dzii oluşturulacak
             * dizinin içerisine 0 yada 1 değeri atanacak
             * Gelen eğerler toplanıp olasılık hesabı yapılacak.
             */
            int deneme = 0;
            Console.WriteLine("deneme sayısı giriniz:");

            deneme= int.Parse(Console.ReadLine());
            Random rnd= new Random();
            int[] yazıtura= new int[deneme];
            for (int i = 0; i < deneme; i++)
            {
                yazıtura[i] = rnd.Next(2);
            }
            int yazı = 0, tura = 0;

            for (int i = 0; i < deneme; i++)
            {
                if (yazıtura[i] == 0)
                    yazı = yazı + 1;
                else
                    tura = tura + 1;
            }
            Console.WriteLine("yazı:" + yazı);
            Console.WriteLine("tura:" + tura);


            /*deneme sayısı ekrandan alınacak
            her atılan basket sonucu bir dizide tutulacak
            iki takımın müsabakasını yapıp sonucu ekrana yazınız*/

            int denemesayısı = 150;

            byte[] Fenerbahçe = new byte[denemesayısı];
            byte[] Galatasaray = new byte[denemesayısı];
            Random random = new Random();


            //Maçın yapıldığı döngü burası
            for (int i = 0; i < denemesayısı; i++)
            {
                Fenerbahçe[i] = (byte)random.Next(4);
                Galatasaray[i] = (byte)random.Next(4);
            }
            int bos = 0, serbestatıs = 0, ikiliatis = 0, uçlukatıs = 0;
            int gsbos = 0, gsserbest = 0, gsikili = 0, gsuçluk = 0;



            //Maç sonu istatislikler
            for (int i = 0; i < denemesayısı; i++)
            {
                switch (Fenerbahçe[i])
                {
                    case 0:
                        bos = bos + 1;
                        break;
                    case 1:
                        serbestatıs = serbestatıs + 1;
                        break ;
                     case 2:
                        ikiliatis = ikiliatis + 1;
                        break;
                    case 3:
                        uçlukatıs = uçlukatıs + 1;
                        break;
                    default:
                        break;


                }
                switch (Galatasaray[i])
                {
                    case 0:
                        gsbos = gsbos + 1;
                        break;
                    case 1:
                        gsserbest = gsserbest + 1;
                        break;
                    case 2:
                        gsikili = gsikili + 1;
                        break;
                    case 3:
                        gsuçluk = gsuçluk + 1;
                        break;
                        default :
                        break;
                        


                }
            }
            Console.WriteLine("çekilen şut      Fenerbahçe        Galatasaray");
            Console.WriteLine("-----------      ----------        ------------");
            Console.WriteLine($"Boş                {bos}             {gsbos}");
            Console.WriteLine($"Serbest          {serbestatıs}       {gsserbest}");
            Console.WriteLine($"ikilik            {ikiliatis}         {gsikili}");
            Console.WriteLine($"üçlük             {uçlukatıs}         {gsuçluk}");
            Console.WriteLine($"Maç sonucu    {serbestatıs + ikiliatis + uçlukatıs} {gsikili+gsserbest+gsuçluk}");

        }   

                    

    }
}
