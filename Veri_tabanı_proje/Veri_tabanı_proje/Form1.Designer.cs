
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
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(314, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "OTEL FORWHAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(231, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lütfen yapmak istediğiniz işlemi seçiniz.";
            // 
            // btn_yoneticiGiris
            // 
            this.btn_yoneticiGiris.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yoneticiGiris.Location = new System.Drawing.Point(348, 287);
            this.btn_yoneticiGiris.Name = "btn_yoneticiGiris";
            this.btn_yoneticiGiris.Size = new System.Drawing.Size(214, 54);
            this.btn_yoneticiGiris.TabIndex = 7;
            this.btn_yoneticiGiris.Text = "Yönetici Girişi Yap";
            this.btn_yoneticiGiris.UseVisualStyleBackColor = true;
            // 
            // btn_rezervYap
            // 
            this.btn_rezervYap.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rezervYap.Location = new System.Drawing.Point(348, 383);
            this.btn_rezervYap.Name = "btn_rezervYap";
            this.btn_rezervYap.Size = new System.Drawing.Size(220, 54);
            this.btn_rezervYap.TabIndex = 8;
            this.btn_rezervYap.Text = "Rezervasyon Yap";
            this.btn_rezervYap.UseVisualStyleBackColor = true;
            // 
            // form_anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veri_tabanı_proje.Properties.Resources.Resim6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 593);
            this.Controls.Add(this.btn_rezervYap);
            this.Controls.Add(this.btn_yoneticiGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

