﻿
namespace Veri_tabanı_proje
{
    partial class Yönetici_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yönetici_giris));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_kullanici_adi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_girisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel_sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(342, 574);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kullanici_adi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_kullanici_adi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_kullanici_adi.HintForeColor = System.Drawing.Color.Empty;
            this.txt_kullanici_adi.HintText = "";
            this.txt_kullanici_adi.isPassword = false;
            this.txt_kullanici_adi.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_kullanici_adi.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_kullanici_adi.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_kullanici_adi.LineThickness = 3;
            this.txt_kullanici_adi.Location = new System.Drawing.Point(509, 210);
            this.txt_kullanici_adi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(350, 44);
            this.txt_kullanici_adi.TabIndex = 1;
            this.txt_kullanici_adi.Text = "Kullanıcı Adı";
            this.txt_kullanici_adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_sifre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_sifre.HintText = "";
            this.txt_sifre.isPassword = false;
            this.txt_sifre.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txt_sifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_sifre.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txt_sifre.LineThickness = 3;
            this.txt_sifre.Location = new System.Drawing.Point(509, 300);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(350, 44);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.Text = "Şifre";
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(586, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "YÖNETİCİ GİRİŞİ";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.ActiveBorderThickness = 1;
            this.btn_girisYap.ActiveCornerRadius = 20;
            this.btn_girisYap.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_girisYap.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_girisYap.ActiveLineColor = System.Drawing.Color.White;
            this.btn_girisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_girisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_girisYap.BackgroundImage")));
            this.btn_girisYap.ButtonText = "Giriş Yap";
            this.btn_girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisYap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_girisYap.IdleBorderThickness = 1;
            this.btn_girisYap.IdleCornerRadius = 20;
            this.btn_girisYap.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_girisYap.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_girisYap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_girisYap.Location = new System.Drawing.Point(549, 425);
            this.btn_girisYap.Margin = new System.Windows.Forms.Padding(5);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(234, 54);
            this.btn_girisYap.TabIndex = 4;
            this.btn_girisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(586, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 1);
            this.label2.TabIndex = 5;
            this.label2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(450, 309);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel_sifremiUnuttum
            // 
            this.linkLabel_sifremiUnuttum.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel_sifremiUnuttum.AutoSize = true;
            this.linkLabel_sifremiUnuttum.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.linkLabel_sifremiUnuttum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel_sifremiUnuttum.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel_sifremiUnuttum.Location = new System.Drawing.Point(733, 383);
            this.linkLabel_sifremiUnuttum.Name = "linkLabel_sifremiUnuttum";
            this.linkLabel_sifremiUnuttum.Size = new System.Drawing.Size(126, 20);
            this.linkLabel_sifremiUnuttum.TabIndex = 11;
            this.linkLabel_sifremiUnuttum.TabStop = true;
            this.linkLabel_sifremiUnuttum.Text = "Şifremi unuttum..";
            // 
            // Yönetici_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 574);
            this.Controls.Add(this.linkLabel_sifremiUnuttum);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Yönetici_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici_giris";
            this.Load += new System.EventHandler(this.Yönetici_giris_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_girisYap;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_kullanici_adi;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_sifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}