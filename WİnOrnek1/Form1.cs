using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WİnOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> araclar = new List<string>();
            araclar.Add("tofaş");
            araclar.Add("Bmw");
            araclar.Add("mercedes");
            araclar.Add("subaru");

            foreach (var araba in araclar)
            {
                listBox1.Items.Add(araba);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //rastgele 50 syı oluşturunuz
            //tek sayılırı listbox1 e 
            //cift sayıları listbox2 ye 
            //hem 3 hem 5 bölünenleride ayrı bi listeye atınız
            Random rnd = new Random();
            int sayi = 0;
            for (int i = 0; i < 50; i++)
            {
                sayi = rnd.Next(100);
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
                if (sayi % 15 == 0)
                {
                    listBox3.Items.Add(sayi);


                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string deger = txtSayi.Text;
            int elemansayisi = int.Parse(deger);
            int[] sayilar = new int[elemansayisi];
            Random rand = new Random();
            int[] frekans = new int[10];
            //Girilen eleman sayısı kadar 1-10 arasında sayı üretsin

            for (int i = 0; i < elemansayisi; i++)
            {
                sayilar[i] = rand.Next(11);
            }
            //oluşturulan dizideki sayıların frekansı nedir(tekrar sayısı
            //sonuçları listbox'a yazınız

            for (int i = 0; i < frekans.Length; i++)
            {
                switch (sayilar[i])
                {
                    case 0:
                        frekans[0]++;
                        break;

                    case 1:
                        frekans[1]++;
                        break;

                    case 2:
                        frekans[2]++;
                        break;

                    case 3:
                        frekans[3]++;
                        break;

                    case 4:
                        frekans[4]++;
                        break;

                    case 5:
                        frekans[5]++;
                        break;

                    case 6:
                        frekans[6]++;
                        break;

                    case 7:
                        frekans[7]++;
                        break;

                    case 8:
                        frekans[8]++;
                        break;

                    case 9:
                        frekans[9]++;
                        break;

                    case 10:
                        frekans[10]++;
                        break;


                }
            }

            for (int i = 0; i < frekans.Length; i++)
            {
                listBox1.Items.Add(i + "=>" + frekans[i]);
            }

            //1 random değerler atayin
            //2 frekans hesabi yapılıcak
            //3- Listboxa eklenecek
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* içeriğine sizin karar vereceğiniz bir syıal dizi 
             * oluşturun ve bu dizinin en küçük - en büyük elemanını
             * messageboxla gösteriniz*/

            Random rnd = new Random();  
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i]= rnd.Next(100);
                listBox1.Items.Add(sayilar[i]);
            }
            int enKucuk = sayilar[0], enBuyuk = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (enKucuk > sayilar[i])
                {
                    enKucuk = sayilar[i];
                }
                if (enBuyuk < sayilar[i])
                {
                    enBuyuk = sayilar[i];
                }
            }
             listBox2.Items.Add("En Kucuk:" + enKucuk);
             listBox3.Items.Add("En Kucuk:" + enBuyuk);
        }    
    }
}
