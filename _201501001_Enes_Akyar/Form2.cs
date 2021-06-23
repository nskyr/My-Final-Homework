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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
       
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        string dosyaYolu = @"c:\gorsel\kayit.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "" || txtSifre.Text == "" || txtToplam.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTcNo.Text.Length < 11)
            {
                MessageBox.Show("TC No 11 haneli olmalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSifre.Text.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır!", "Şifre Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtToplam.Text!=lblKontrol.Text)
            {
                MessageBox.Show("Yanlış toplam!", "toplam Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Random rastgeleSayi = new Random();
                int sayi1 = rastgeleSayi.Next(0, 100);
                int sayi2 = rastgeleSayi.Next(0, 100);
                int toplam = sayi1 + sayi2;
                lblSayi1.Text = sayi1.ToString();
                lblSayi2.Text = sayi2.ToString();
                lblKontrol.Text = toplam.ToString();
                txtToplam.Clear();
                txtToplam.Focus();
                return;
            }
            if (File.Exists(dosyaYolu) == false)
            {
                using (File.Create(dosyaYolu))
                {

                }
            }
            string[] satirlar = File.ReadAllLines(dosyaYolu);
            bool varMi = false;
            foreach (string satir in satirlar)
            {
                string[] veriler = satir.Split(',');
                if (veriler[3] == txtTcNo.Text && veriler[5] == txtSifre.Text)
                {
                    varMi = true;
                }
            }
            
            if(varMi)
            {
                frmOyun frm = new frmOyun();
                frm.Show();
                this.Close();
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı TC No veya şifre hatalı!");
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            Random rastgeleSayi = new Random();
            int sayi1 = rastgeleSayi.Next(0, 100);
            int sayi2 = rastgeleSayi.Next(0, 100);
            int toplam = sayi1 + sayi2;
            lblSayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();
            lblKontrol.Text = toplam.ToString();
            
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
                MessageBox.Show("Kayıt Başarılı");
        }
    }
}
