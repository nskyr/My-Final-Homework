using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201501001_Enes_Akyar
{
    public partial class frmHosgeldin : Form
    {
        public frmHosgeldin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmGiris girisSayfasi = new frmGiris();            
            this.Hide();
            girisSayfasi.Show();
            timer1.Enabled = false;
        }

        private void frmHosgeldin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGiris girisSayfasi = new frmGiris();
            this.Hide();
            girisSayfasi.Show();
            timer1.Enabled = false;
        }
    }
}
