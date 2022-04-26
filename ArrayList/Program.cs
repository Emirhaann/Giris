using System;
using System.Collections;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            dizi.Add("adana");
            dizi.Add(1);
            dizi.Add(new DateTime());
            dizi.Add(true);
            dizi.Add("urfa");
            dizi.Add("Bursa");
            dizi.Add("Edirne");
            dizi.Add("İzmir");
            dizi.Add("Ayşe");
            dizi.Add("Fatma");

            //Araya eleman eklemek istersek
            dizi.Insert(3, "Ali");
            dizi.Insert(5, "Veli");

            //verilen elemanı listeden kaldırmak için
            dizi.Remove("veli");

            //ArrayList'i Sıralamak için .sort() kullanılır
            dizi.Sort();

            // o anki kapasiteyi o anki eleman sayısına eşitlemek içinse 
            dizi.TrimToSize();
         
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
