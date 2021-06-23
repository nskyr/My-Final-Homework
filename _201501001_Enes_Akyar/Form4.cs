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

namespace _201501001_Enes_Akyar
{
    public partial class frmOyun : Form
    {
        public frmOyun()
        {
            InitializeComponent();
        }
        int hak = 0, sayi = 0, tahmin = 0;
        string dosyaYolu = @"c:\gorsel\oyun.txt";
        int sayac = 0;
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            lblinfo.Visible = true;
            txtTahmin.Visible = true;
            btnTahmin.Visible = true;
            label4.Visible = true;
            lblSure.Visible = true;
            timer1.Enabled = true;
            Random rastgeleSayi = new Random();
            sayi = rastgeleSayi.Next(100);
            lblTahminEdilcekSayi.Text = sayi.ToString();
            lblinfo.Text ="1 ile 100 arası bir sayı tahmin edin.";
            lblSure.Text = "0";
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = int.Parse(lblSure.Text);
            sayac++;
            lblSure.Text = sayac.ToString();
        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Length > 0)
            {
                btnTahmin.Enabled = true;
            }
            else if (txtTahmin.Text.Length == 0)
                btnTahmin.Enabled = false;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            hak++;
            tahmin = int.Parse(txtTahmin.Text);
            txtTahmin.Clear();
            txtTahmin.Focus();
            if (tahmin > sayi)
                lblinfo.Text = tahmin + " sayısından küçük bir değer girin";
            else if (tahmin == 0)
                lblinfo.Text = "0 dan farklı bir sayı deneyin.";
            else if (tahmin < sayi)
                lblinfo.Text = tahmin + " sayısından büyük bir değer girin";
            // doğru bilinrse
            else
            {
                lblinfo.Visible = false;
                txtTahmin.Visible = false;
                btnTahmin.Visible = false;
                label4.Visible = false;
                lblSure.Visible = false;
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler,bildiniz!");
                if (File.Exists(dosyaYolu) == false)
                {
                    using (File.Create(dosyaYolu))
                    {

                    }
                }
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    string satir = hak + "," + lblSure.Text + "," + DateTime.Now.ToString();
                    dosya.WriteLine(satir);
                }
            }
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {
            string[] skorlar = File.ReadAllLines(dosyaYolu);
            foreach (string skor in skorlar)
            {
                string[] veriler = skor.Split(',');
                lstSkor.Items.Add(veriler[0]+" hak"+ "," + veriler[1]+" saniye");
            }

        }
    }
}
