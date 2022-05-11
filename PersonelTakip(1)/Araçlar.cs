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

namespace PersonelTakip
{
    public partial class Araçlar : Form
    {

        string marka, model, renk, kasa, vites, guvenlikpaketi, Donanimpaketi,
            motor, yakıt;



        //Kasatipleri: cupe, sedan, cabrio, hatchback, station wagon
        List<arac> Arabalar = new List<arac>();


        public enum Kasatipi   //ENUM çok fazla seçenek varsa enum kullanarak indexlerin otomatik gelir seçersin yani
        {
            cupe, 
            sedan,
            cabrio, 
            hatchback, 
            stationWagon
        }

        public enum Yakıttipi
        {
            Benzin,
            Motorin,
            Elektrik,
            Hybrid
        }
        
        public enum Vites
        {
            Manuel,
            YariOtomatik,
            Otomatik
        }

        public enum DonanimPaketi
        {
            Full,
            FullArtiFull,
            Bos
        }

        struct Araba
        {
            public string marka;
            public string model;
            public string renk;
            public Kasatipi kasa;
            public Vites vites;
            public string guvenlikpaketi;            
            public string motor;
            public Yakıttipi yakıt;
            public DonanimPaketi paket;
            public DateTime cikisYili;
            private int MotorGucu;
            
            public void SetMotorGucu(int motorgucuu)
            {
                MotorGucu = MotorGucu;
            }

            public int GetMotorGucu()
            {
                return MotorGucu;
            }
        }

        public class arac
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
            public Kasatipi Kasa { get; set; }
            public Vites Vites { get; set; }
            public string guvenlikPaketi { get; set; }
            public string Motor { get; set; }
            public Yakıttipi YakitTipi { get; set; }
            public DonanimPaketi DonanimPaketi { get; set; }
            public int MotorGucu { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araç = new Araba();
           // araç.SetMotorGucu(500);
            araç.kasa = (Kasatipi)Enum.Parse(typeof(Kasatipi),cmbKasa.Text);
            araç.yakıt =(Yakıttipi) Enum.Parse(typeof(Yakıttipi), cmbYakit.Text);
            araç.vites= (Vites)Enum.Parse(typeof(Vites),cmbVites.Text);
            araç.paket = (DonanimPaketi)Enum.Parse(typeof(DonanimPaketi), cmbDonanim.Text);

            araç.motor = txtMotor.Text;
            araç.renk = txtRenk.Text;
            araç.marka =txtMarka.Text;
            araç.model= txtModel.Text;

            StreamWriter sw = File.AppendText("Arabalar.txt");

            string YazilacakSatir = araç.marka + ";" + araç.model + ";" + araç.renk + ";";
            YazilacakSatir += araç.motor + ";" + araç.kasa + ";" + araç.vites + ";" + araç.paket + ";";
            sw.WriteLine(YazilacakSatir);
            sw.Close();

            arac bmw = new arac();
            bmw.Marka = "Bmw";
            bmw.Renk = "Siyah";
            bmw.guvenlikPaketi = "Full";
            bmw.Kasa = Kasatipi.hatchback;
            bmw.MotorGucu = 200;
            bmw.Vites = Vites.Otomatik;
            bmw.YakitTipi = Yakıttipi.Elektrik;
            Arabalar.Add(bmw);

            
            arac alfa = new arac();
            alfa.Marka = "AlfaRomeo";
            alfa.Renk = "Siyah";
            alfa.guvenlikPaketi = "Full";
            alfa.Kasa = Kasatipi.hatchback;
            alfa.MotorGucu = 200;
            alfa.Vites = Vites.Otomatik;
            alfa.YakitTipi = Yakıttipi.Elektrik;
            Arabalar.Add(alfa);

                dataGridView1.DataSource = Arabalar.ToList();


        }

        public Araçlar()
        {
            InitializeComponent();
        }

        private void Araçlar_Load(object sender, EventArgs e)
        {
           //Donaım paketlerini ekliyoruz
      
            cmbDonanim.Items.AddRange(Enum.GetNames(typeof(DonanimPaketi)));
            cmbDonanim.SelectedIndex = 0;

            //Kasa tiplerini Comboxa ekliyoruz
            cmbKasa.Items.AddRange(Enum.GetNames(typeof(Kasatipi)));
            cmbKasa.SelectedIndex = 0;

            //Yakit Tipini Ekliyoruz
            cmbYakit.Items.AddRange(Enum.GetNames(typeof(Yakıttipi)));
            cmbYakit.SelectedIndex = 0;

            //Vites Tipini Ekliyoruz
            cmbVites.Items.AddRange(Enum.GetNames(typeof(Vites)));
            cmbVites.SelectedIndex = 0;

        }
    }
}
