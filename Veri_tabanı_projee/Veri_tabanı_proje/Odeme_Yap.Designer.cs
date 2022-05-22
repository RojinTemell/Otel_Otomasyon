namespace Veri_tabanı_proje
{
    partial class Odeme_Yap
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
            this.txtKrediKartNo = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblSKT = new System.Windows.Forms.Label();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYıl = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTesvikRez = new System.Windows.Forms.RadioButton();
            this.rbStandartRez = new System.Windows.Forms.RadioButton();
            this.rb60GunOncedenRez = new System.Windows.Forms.RadioButton();
            this.rbOnOdemeRez = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKrediKartNo
            // 
            this.txtKrediKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKrediKartNo.Location = new System.Drawing.Point(442, 68);
            this.txtKrediKartNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKrediKartNo.Multiline = true;
            this.txtKrediKartNo.Name = "txtKrediKartNo";
            this.txtKrediKartNo.Size = new System.Drawing.Size(226, 35);
            this.txtKrediKartNo.TabIndex = 0;
            this.txtKrediKartNo.Text = "   Kredi Kartı No";
            this.txtKrediKartNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKrediKartNo_MouseClick);
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCVV.Location = new System.Drawing.Point(706, 68);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCVV.Multiline = true;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(83, 35);
            this.txtCVV.TabIndex = 1;
            this.txtCVV.Text = "  CVV";
            this.txtCVV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCVV_MouseClick);
            // 
            // lblSKT
            // 
            this.lblSKT.AutoSize = true;
            this.lblSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSKT.Location = new System.Drawing.Point(437, 146);
            this.lblSKT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(195, 25);
            this.lblSKT.TabIndex = 2;
            this.lblSKT.Text = "Son Kullanma Tarihi:";
            this.lblSKT.Click += new System.EventHandler(this.lblSKT_Click);
            // 
            // cmbAy
            // 
            this.cmbAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbAy.Location = new System.Drawing.Point(642, 143);
            this.cmbAy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(75, 33);
            this.cmbAy.TabIndex = 3;
            this.cmbAy.Text = "  Ay";
            // 
            // cmbYıl
            // 
            this.cmbYıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYıl.FormattingEnabled = true;
            this.cmbYıl.Items.AddRange(new object[] {
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbYıl.Location = new System.Drawing.Point(741, 143);
            this.cmbYıl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbYıl.Name = "cmbYıl";
            this.cmbYıl.Size = new System.Drawing.Size(67, 33);
            this.cmbYıl.TabIndex = 4;
            this.cmbYıl.Text = " Yıl";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTesvikRez);
            this.groupBox1.Controls.Add(this.rbStandartRez);
            this.groupBox1.Controls.Add(this.rb60GunOncedenRez);
            this.groupBox1.Controls.Add(this.rbOnOdemeRez);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(354, 312);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasyon Tipi Seçiniz";
            // 
            // rbTesvikRez
            // 
            this.rbTesvikRez.AutoSize = true;
            this.rbTesvikRez.BackColor = System.Drawing.Color.Transparent;
            this.rbTesvikRez.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTesvikRez.ForeColor = System.Drawing.Color.Black;
            this.rbTesvikRez.Location = new System.Drawing.Point(31, 245);
            this.rbTesvikRez.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbTesvikRez.Name = "rbTesvikRez";
            this.rbTesvikRez.Size = new System.Drawing.Size(210, 28);
            this.rbTesvikRez.TabIndex = 74;
            this.rbTesvikRez.TabStop = true;
            this.rbTesvikRez.Text = "Teşvik Rezervasyon";
            this.rbTesvikRez.UseVisualStyleBackColor = false;
            // 
            // rbStandartRez
            // 
            this.rbStandartRez.AutoSize = true;
            this.rbStandartRez.BackColor = System.Drawing.Color.Transparent;
            this.rbStandartRez.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbStandartRez.ForeColor = System.Drawing.Color.Black;
            this.rbStandartRez.Location = new System.Drawing.Point(31, 188);
            this.rbStandartRez.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbStandartRez.Name = "rbStandartRez";
            this.rbStandartRez.Size = new System.Drawing.Size(232, 28);
            this.rbStandartRez.TabIndex = 73;
            this.rbStandartRez.TabStop = true;
            this.rbStandartRez.Text = "Standart Rezervasyon";
            this.rbStandartRez.UseVisualStyleBackColor = false;
            // 
            // rb60GunOncedenRez
            // 
            this.rb60GunOncedenRez.AutoSize = true;
            this.rb60GunOncedenRez.BackColor = System.Drawing.Color.Transparent;
            this.rb60GunOncedenRez.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb60GunOncedenRez.ForeColor = System.Drawing.Color.Black;
            this.rb60GunOncedenRez.Location = new System.Drawing.Point(31, 137);
            this.rb60GunOncedenRez.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rb60GunOncedenRez.Name = "rb60GunOncedenRez";
            this.rb60GunOncedenRez.Size = new System.Drawing.Size(303, 28);
            this.rb60GunOncedenRez.TabIndex = 72;
            this.rb60GunOncedenRez.TabStop = true;
            this.rb60GunOncedenRez.Text = "60 Gün Önceden Rezervasyon";
            this.rb60GunOncedenRez.UseVisualStyleBackColor = false;
            // 
            // rbOnOdemeRez
            // 
            this.rbOnOdemeRez.AutoSize = true;
            this.rbOnOdemeRez.BackColor = System.Drawing.Color.Transparent;
            this.rbOnOdemeRez.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOnOdemeRez.ForeColor = System.Drawing.Color.Black;
            this.rbOnOdemeRez.Location = new System.Drawing.Point(31, 86);
            this.rbOnOdemeRez.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbOnOdemeRez.Name = "rbOnOdemeRez";
            this.rbOnOdemeRez.Size = new System.Drawing.Size(260, 28);
            this.rbOnOdemeRez.TabIndex = 71;
            this.rbOnOdemeRez.TabStop = true;
            this.rbOnOdemeRez.Text = "Ön Ödemeli Rezervasyon";
            this.rbOnOdemeRez.UseVisualStyleBackColor = false;
            // 
            // Odeme_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 837);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbYıl);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.lblSKT);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtKrediKartNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Odeme_Yap";
            this.Text = "Odeme_Yap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKrediKartNo;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblSKT;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYıl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTesvikRez;
        private System.Windows.Forms.RadioButton rbStandartRez;
        private System.Windows.Forms.RadioButton rb60GunOncedenRez;
        private System.Windows.Forms.RadioButton rbOnOdemeRez;
    }
}