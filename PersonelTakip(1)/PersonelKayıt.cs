using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip_1_
{
    public partial class PersonelKayıt : Form
    {
        string ad, soyad, tcno, gsm, email;
        List<string> Adlar =new List<string>();
        List<string> Soyadlar = new List<string>();
        List<string> TcNolar= new List<string>();   
        List<string> Gsmler= new List<string>();
        List<string> Emailler = new List<string>();
        List<DateTime> Dogumtarihleri = new List<DateTime>();


        DateTime dogumtarihi;
        public PersonelKayıt()
        {
            InitializeComponent();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("Persone.txt");
            foreach (var satir in satirlar)
            {
                string[] veriler = satir.Split(";");
                Adlar.Add(veriler[0]);
                Soyadlar.Add(veriler[1]);
                Gsmler.Add(veriler[2]);
                Emailler.Add(veriler[3]);
                TcNolar.Add(veriler[4]);
                Dogumtarihleri.Add(Convert.ToDateTime(veriler[5]));
            }
        }

        private void txtSoyad_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ekrandan Değerleri Oku

            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            gsm = txtGsm.Text;
            email = txtEmail.Text;
            tcno = txtTcNo.Text;

            dogumtarihi = dtpDogumTarihi.Value;
            #endregion

            #region Gelern Verileri Kontrol Et

            if (ad.Length < 2)
            {
                MessageBox.Show("Ad alani en az iki karakter olmadılır..");
                return;
            }
            if (soyad.Length < 2)
            {
                MessageBox.Show("Soyad alanı en az iki karakter olmalıdır..");
                return;
            }
            if (gsm.Length < 10)
            {
                MessageBox.Show("Gsm alanı en az 10 karakter olmadılır..");
                return;
            }
            if (!(tcno.Length == 11))
            {
                MessageBox.Show("tcNo alanı 11 karakter olmalıdır..");
                return;
            }
            if (dogumtarihi.Year > 2005 && dogumtarihi.Year < DateTime.Now.Year)
            {
                MessageBox.Show("yaşınınz tutmadı..");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("email düzgün formatta olmalıdır.");
                return;
            }
            #endregion


            #region Dosyaya Yazma

            string path = @"Personel.txt"; //PATH YOL DEMEK NEREYE GÖNDERĞİCEİNİ BELİRLERSİN
                                              //bişey yazmadık ondan programın kurulu olduğu yere atıcak

            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(ad + ";" + soyad + ";" + gsm + ";" + email + ";" + tcno + ";" + dogumtarihi);
            sw.Close();

            
            #endregion
        }

        public void FormuTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtGsm.Text = "";
            txtTcNo.Text = "";
            dateTimePicker.Value = DateTime.Now;

        }

        private void PersonelKayıt_2__Load(object sender, EventArgs e)
        {

        }
    }
}
