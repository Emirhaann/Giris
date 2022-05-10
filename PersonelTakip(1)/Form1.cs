using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // KullanıcıAdı: admin
            // Şifre: qweasd
            

            if (txtKullanici.Text == "admin" && txtŞifre.Text == "qweasd")
            {
                PersonelKayıt personeFrm = new PersonelKayıt();

                personeFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalıdır");
            }
        }
    }
}
