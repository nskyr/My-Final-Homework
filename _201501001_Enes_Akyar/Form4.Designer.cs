
namespace _201501001_Enes_Akyar
{
    partial class frmOyun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTahminEdilcekSayi = new System.Windows.Forms.Label();
            this.lstSkor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(155, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı Tahmin Oyunu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(533, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Önceki Skorlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinfo.Location = new System.Drawing.Point(61, 204);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(417, 27);
            this.lblinfo.TabIndex = 3;
            this.lblinfo.Text = "1 ile 100 arasında bir sayı tahmin ediniz.";
            this.lblinfo.Visible = false;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(198, 257);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 34);
            this.txtTahmin.TabIndex = 4;
            this.txtTahmin.Visible = false;
            this.txtTahmin.TextChanged += new System.EventHandler(this.txtTahmin_TextChanged);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Enabled = false;
            this.btnTahmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(168, 297);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(158, 39);
            this.btnTahmin.TabIndex = 5;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Visible = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Süre : ";
            this.label4.Visible = false;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(140, 367);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(24, 27);
            this.lblSure.TabIndex = 7;
            this.lblSure.Text = "0";
            this.lblSure.Visible = false;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.Location = new System.Drawing.Point(66, 439);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(158, 39);
            this.btnYeniOyun.TabIndex = 8;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(301, 439);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(158, 39);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTahminEdilcekSayi
            // 
            this.lblTahminEdilcekSayi.AutoSize = true;
            this.lblTahminEdilcekSayi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahminEdilcekSayi.Location = new System.Drawing.Point(91, 528);
            this.lblTahminEdilcekSayi.Name = "lblTahminEdilcekSayi";
            this.lblTahminEdilcekSayi.Size = new System.Drawing.Size(30, 27);
            this.lblTahminEdilcekSayi.TabIndex = 11;
            this.lblTahminEdilcekSayi.Text = "...";
            this.lblTahminEdilcekSayi.Visible = false;
            // 
            // lstSkor
            // 
            this.lstSkor.BackColor = System.Drawing.Color.Aquamarine;
            this.lstSkor.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSkor.FormattingEnabled = true;
            this.lstSkor.ItemHeight = 23;
            this.lstSkor.Location = new System.Drawing.Point(532, 297);
            this.lstSkor.Name = "lstSkor";
            this.lstSkor.Size = new System.Drawing.Size(212, 188);
            this.lstSkor.TabIndex = 12;
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.lstSkor);
            this.Controls.Add(this.lblTahminEdilcekSayi);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmOyun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "201501001-Enes AKYAR";
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTahminEdilcekSayi;
        private System.Windows.Forms.ListBox lstSkor;
    }
}