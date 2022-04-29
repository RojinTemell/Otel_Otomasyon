
namespace Veri_tabanı_proje
{
    partial class Yonetici_Ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Ekran));
            this.dataGrid_odalar = new System.Windows.Forms.DataGridView();
            this.dataGrid_misafirler = new System.Windows.Forms.DataGridView();
            this.dataGrid_calisanlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_misafirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_calisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_odalar
            // 
            this.dataGrid_odalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_odalar.Location = new System.Drawing.Point(12, 32);
            this.dataGrid_odalar.Name = "dataGrid_odalar";
            this.dataGrid_odalar.RowHeadersWidth = 51;
            this.dataGrid_odalar.RowTemplate.Height = 24;
            this.dataGrid_odalar.Size = new System.Drawing.Size(572, 666);
            this.dataGrid_odalar.TabIndex = 0;
            // 
            // dataGrid_misafirler
            // 
            this.dataGrid_misafirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_misafirler.Location = new System.Drawing.Point(590, 387);
            this.dataGrid_misafirler.Name = "dataGrid_misafirler";
            this.dataGrid_misafirler.RowHeadersWidth = 51;
            this.dataGrid_misafirler.RowTemplate.Height = 24;
            this.dataGrid_misafirler.Size = new System.Drawing.Size(628, 311);
            this.dataGrid_misafirler.TabIndex = 1;
            // 
            // dataGrid_calisanlar
            // 
            this.dataGrid_calisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_calisanlar.Location = new System.Drawing.Point(590, 32);
            this.dataGrid_calisanlar.Name = "dataGrid_calisanlar";
            this.dataGrid_calisanlar.RowHeadersWidth = 51;
            this.dataGrid_calisanlar.RowTemplate.Height = 24;
            this.dataGrid_calisanlar.Size = new System.Drawing.Size(628, 325);
            this.dataGrid_calisanlar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odalar Veri Tabanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(590, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çalışanlar Veri Tabanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(590, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Misafirler Veri Tabanı";
            // 
            // Yonetici_Ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 710);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_calisanlar);
            this.Controls.Add(this.dataGrid_misafirler);
            this.Controls.Add(this.dataGrid_odalar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yonetici_Ekran";
            this.Text = "Yonetici_Ekran";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_misafirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_calisanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_odalar;
        private System.Windows.Forms.DataGridView dataGrid_misafirler;
        private System.Windows.Forms.DataGridView dataGrid_calisanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}