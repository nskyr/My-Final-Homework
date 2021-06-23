using _201501001_Enes_Akyar.MernisServiceReference;
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
    public partial class frmKayit : Form
    {
        
        public frmKayit()
        {
            InitializeComponent();
        }

        bool sonuc;
        string dosyaYolu = @"c:\gorsel\kayit.txt";
        string dosyaYoluHata = @"c:\gorsel\hata.txt";

        private void frmKayit_Load(object sender, EventArgs e)
        {
        }

        private void nmrDogumYili_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            //boşluk kontrol
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTcNo.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //sifre uzunluk kontrol
            if (txtTcNo.Text.Length < 11)
            {
                MessageBox.Show("TC No 11 haneli olmalı !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSifre.Text.Length<6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır!", "Şifre Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KPSPublicSoapClient servis = new KPSPublicSoapClient();
                long tcNoLong = Convert.ToInt64(txtTcNo.Text);
                int dogumYiliInt = Convert.ToInt32(nmrDogumYili.Text);
                sonuc = servis.TCKimlikNoDogrula(tcNoLong, txtAd.Text.ToString(), txtSoyad.Text.ToString(), dogumYiliInt);              
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (File.Exists(dosyaYoluHata) == false)
                {
                    using (File.Create(dosyaYoluHata))
                    {

                    }
                }
                    using (StreamWriter dosya = new StreamWriter(dosyaYoluHata, true))
                    {
                        string satir = ex.Message + "," + DateTime.Now.ToString();
                        dosya.WriteLine(satir);
                    }
            }
            if(sonuc==false)
            {
                MessageBox.Show("Verdiğiniz bilgiler MERNİS ile uyuşmuyor ! ");
                return;
            }
            //dosyayolu var mı?
            if (File.Exists(dosyaYolu)==false)
            {
                using(File.Create(dosyaYolu))
                {

                }
            }
            //tcno kontrol
            string[] satirlar = File.ReadAllLines(dosyaYolu);
            foreach(string satir in satirlar)
            {
                string[] veriler = satir.Split(',');
                if (veriler[3]==txtTcNo.Text)
                {
                    MessageBox.Show("Bu TC No ile kayıt var!", "Tc No Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }               
            }

            using(StreamWriter dosya = new StreamWriter(dosyaYolu,true))
            {
                string ad, soyad, tcno, dyili, sifre, satir;
                ad = txtAd.Text;
                soyad = txtSoyad.Text;
                tcno = txtTcNo.Text;
                dyili = nmrDogumYili.Value.ToString();
                sifre = txtSifre.Text;
                satir = Guid.NewGuid()+","+ad + "," + soyad + "," + tcno + "," + dyili + "," + sifre;
                dosya.WriteLine(satir);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length < 6)
                btnKaydet.Enabled = false;
            else
                btnKaydet.Enabled = true;
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
