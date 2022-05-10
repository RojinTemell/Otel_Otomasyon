
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_anaEkran));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yoneticiGiris = new System.Windows.Forms.Button();
            this.btn_rezervYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(353, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "OTEL FORWHAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(260, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lütfen yapmak istediğiniz işlemi seçiniz.";
            // 
            // btn_yoneticiGiris
            // 
            this.btn_yoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yoneticiGiris.Location = new System.Drawing.Point(392, 359);
            this.btn_yoneticiGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_yoneticiGiris.Name = "btn_yoneticiGiris";
            this.btn_yoneticiGiris.Size = new System.Drawing.Size(241, 68);
            this.btn_yoneticiGiris.TabIndex = 7;
            this.btn_yoneticiGiris.Text = "Yönetici Girişi Yap";
            this.btn_yoneticiGiris.UseVisualStyleBackColor = true;
            this.btn_yoneticiGiris.Click += new System.EventHandler(this.btn_yoneticiGiris_Click);
            // 
            // btn_rezervYap
            // 
            this.btn_rezervYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rezervYap.Location = new System.Drawing.Point(392, 479);
            this.btn_rezervYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_rezervYap.Name = "btn_rezervYap";
            this.btn_rezervYap.Size = new System.Drawing.Size(248, 68);
            this.btn_rezervYap.TabIndex = 8;
            this.btn_rezervYap.Text = "Rezervasyon Yap";
            this.btn_rezervYap.UseVisualStyleBackColor = true;
            this.btn_rezervYap.Click += new System.EventHandler(this.btn_rezervYap_Click);
            // 
            // form_anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veri_tabanı_proje.Properties.Resources.Resim6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 741);
            this.Controls.Add(this.btn_rezervYap);
            this.Controls.Add(this.btn_yoneticiGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form_anaEkran";
            this.Text = "Otel Rezervasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_yoneticiGiris;
        private System.Windows.Forms.Button btn_rezervYap;
    }
}

