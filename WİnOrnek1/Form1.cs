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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text;
            int elemansayisi = int.Parse(deger);
            int[] sayilar = new int[elemansayisi];
            //Girilen eleman sayısı kadar 1-10 arasında sayı üretsin
            //oluşturulan dizideki sayıların frekansı nedir(tekrar sayısı
            //sonuçları listbox'a yazınız

            //1 random değerler atayin
            //2 frekans hesabi yapılıcak
            //3- Listboxa eklenecek
        }
    }
}
