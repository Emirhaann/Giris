using System;
using System.IO;
using System.Text;

namespace System_IO // System ınput/output kütüphanesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Drive info => bilgisayarınızda ki sürücü bilgilerine erişim imkanı verir
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.TotalSize);
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.TotalFreeSpace);
                Console.WriteLine(drive.DriveFormat);
            }

            //DirectoryInfo=> sürücülerde ki Klasörleri verir 
            if (!Directory.Exists(@"c:\benimKlasorum"))
            {
                Directory.CreateDirectory(@"c:\BenimKlasorum");
            }

            string[] dirs = Directory.GetDirectories(@"c:\");

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }


            DosyaOluştur();
        }

        private static void DosyaOluştur()
        {
            //file dosyalarda kullanılur directory kalsörlerde

           FileStream fi= File.Create(@"c:\BenimKlasorum\test.txt");
            Byte[] buffer = new UTF8Encoding(true).GetBytes(@"File: file dosyalarda kullanılur directory kalsörlerde");
            
                fi.Write(buffer);
            fi.Close();  //yapılan yazma işlemi yada oluşturma işlemi kapatılmallıdır.Yoksa yazılma ,işlemi yapılamıyor.
            
            
            //Dosya silmek
            File.Delete(@"c:\benimKlasorum\test.txt");

            //Doysa okumak için
            File.ReadAllText(@"c:\BenimKlasorum\test.txt");


        }
    }
}
