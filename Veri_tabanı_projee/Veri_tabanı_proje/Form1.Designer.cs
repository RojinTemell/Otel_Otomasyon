
namespace Veri_tabanı_proje
{
    partial class form_anaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_anaEkran));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_yoneticiGirisi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_rezervasyon_yap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.btn_rezervasyon_yap);
            this.bunifuGradientPanel1.Controls.Add(this.btn_yoneticiGirisi);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(304, 593);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_yoneticiGirisi
            // 
            this.btn_yoneticiGirisi.ActiveBorderThickness = 1;
            this.btn_yoneticiGirisi.ActiveCornerRadius = 20;
            this.btn_yoneticiGirisi.ActiveFillColor = System.Drawing.Color.SandyBrown;
            this.btn_yoneticiGirisi.ActiveForecolor = System.Drawing.Color.White;
            this.btn_yoneticiGirisi.ActiveLineColor = System.Drawing.Color.SandyBrown;
            this.btn_yoneticiGirisi.BackColor = System.Drawing.Color.Transparent;
            this.btn_yoneticiGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yoneticiGirisi.BackgroundImage")));
            this.btn_yoneticiGirisi.ButtonText = "Yönetici Girişi";
            this.btn_yoneticiGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yoneticiGirisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yoneticiGirisi.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_yoneticiGirisi.IdleBorderThickness = 1;
            this.btn_yoneticiGirisi.IdleCornerRadius = 20;
            this.btn_yoneticiGirisi.IdleFillColor = System.Drawing.Color.White;
            this.btn_yoneticiGirisi.IdleForecolor = System.Drawing.Color.SaddleBrown;
            this.btn_yoneticiGirisi.IdleLineColor = System.Drawing.Color.Maroon;
            this.btn_yoneticiGirisi.Location = new System.Drawing.Point(40, 174);
            this.btn_yoneticiGirisi.Margin = new System.Windows.Forms.Padding(5);
            this.btn_yoneticiGirisi.Name = "btn_yoneticiGirisi";
            this.btn_yoneticiGirisi.Size = new System.Drawing.Size(212, 69);
            this.btn_yoneticiGirisi.TabIndex = 50;
            this.btn_yoneticiGirisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_yoneticiGirisi.Click += new System.EventHandler(this.btn_yoneticiGirisi_Click_1);
            // 
            // btn_rezervasyon_yap
            // 
            this.btn_rezervasyon_yap.ActiveBorderThickness = 1;
            this.btn_rezervasyon_yap.ActiveCornerRadius = 20;
            this.btn_rezervasyon_yap.ActiveFillColor = System.Drawing.Color.SandyBrown;
            this.btn_rezervasyon_yap.ActiveForecolor = System.Drawing.Color.White;
            this.btn_rezervasyon_yap.ActiveLineColor = System.Drawing.Color.SandyBrown;
            this.btn_rezervasyon_yap.BackColor = System.Drawing.Color.Transparent;
            this.btn_rezervasyon_yap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rezervasyon_yap.BackgroundImage")));
            this.btn_rezervasyon_yap.ButtonText = "Rezervasyon Yap";
            this.btn_rezervasyon_yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rezervasyon_yap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rezervasyon_yap.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_rezervasyon_yap.IdleBorderThickness = 1;
            this.btn_rezervasyon_yap.IdleCornerRadius = 20;
            this.btn_rezervasyon_yap.IdleFillColor = System.Drawing.Color.White;
            this.btn_rezervasyon_yap.IdleForecolor = System.Drawing.Color.SaddleBrown;
            this.btn_rezervasyon_yap.IdleLineColor = System.Drawing.Color.Maroon;
            this.btn_rezervasyon_yap.Location = new System.Drawing.Point(40, 346);
            this.btn_rezervasyon_yap.Margin = new System.Windows.Forms.Padding(5);
            this.btn_rezervasyon_yap.Name = "btn_rezervasyon_yap";
            this.btn_rezervasyon_yap.Size = new System.Drawing.Size(212, 73);
            this.btn_rezervasyon_yap.TabIndex = 51;
            this.btn_rezervasyon_yap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_rezervasyon_yap.Click += new System.EventHandler(this.btn_rezervasyon_yap_Click);
            // 
            // form_anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_anaEkran";
            this.Text = "Otel Rezervasyon";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_rezervasyon_yap;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_yoneticiGirisi;
    }
}

