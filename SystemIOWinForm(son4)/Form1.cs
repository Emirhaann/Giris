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

namespace SystemIOWinForm_son4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] tumsuruculer= DriveInfo.GetDrives(); // ilk listboxa c ve d yi getiren getdrives tanımı hazır tanım
            foreach (DriveInfo drive in tumsuruculer)
            {
                lstDriver.Items.Add(drive.Name);
            }
        }

        private void lstDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drive= lstDriver.SelectedItem.ToString();
            string[] drictories = Directory.GetDirectories(drive); 
            lstKlasorler.Items.Clear();
            foreach (string d in drictories)
            {
                lstKlasorler.Items.Add(d);  
            }
        }

        private void lstKlasorler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klasor = lstKlasorler.SelectedItem.ToString();
            string[] klasorler= Directory.GetDirectories(klasor);
            string[] dosyalar = Directory.GetFiles(klasor);
            lstDosyalar.Items.Clear();
            foreach (string d in klasorler)
            {
                lstDosyalar.Items.Add(d);
            }
            foreach (var d in dosyalar)
            {
                lstDosyalar.Items.Add(d);
            }
        }
    }
}
