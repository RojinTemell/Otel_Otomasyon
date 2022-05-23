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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme_Yap));
            this.txtKrediKartNo = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYıl = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTesvikRez = new System.Windows.Forms.RadioButton();
            this.rbStandartRez = new System.Windows.Forms.RadioButton();
            this.rb60GunOncedenRez = new System.Windows.Forms.RadioButton();
            this.rbOnOdemeRez = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSKT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHemenOde = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGeriDon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKrediKartNo
            // 
            this.txtKrediKartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKrediKartNo.Location = new System.Drawing.Point(36, 67);
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
            this.txtCVV.Location = new System.Drawing.Point(299, 67);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCVV.Multiline = true;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(83, 35);
            this.txtCVV.TabIndex = 1;
            this.txtCVV.Text = "  CVV";
            this.txtCVV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCVV_MouseClick);
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
            this.cmbAy.Location = new System.Drawing.Point(187, 148);
            this.cmbAy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(75, 24);
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
            this.cmbYıl.Location = new System.Drawing.Point(299, 148);
            this.cmbYıl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbYıl.Name = "cmbYıl";
            this.cmbYıl.Size = new System.Drawing.Size(67, 24);
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
            this.rbTesvikRez.Size = new System.Drawing.Size(148, 21);
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
            this.rbStandartRez.Size = new System.Drawing.Size(161, 21);
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
            this.rb60GunOncedenRez.Size = new System.Drawing.Size(210, 21);
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
            this.rbOnOdemeRez.Size = new System.Drawing.Size(183, 21);
            this.rbOnOdemeRez.TabIndex = 71;
            this.rbOnOdemeRez.TabStop = true;
            this.rbOnOdemeRez.Text = "Ön Ödemeli Rezervasyon";
            this.rbOnOdemeRez.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKrediKartNo);
            this.groupBox2.Controls.Add(this.txtCVV);
            this.groupBox2.Controls.Add(this.cmbYıl);
            this.groupBox2.Controls.Add(this.lblSKT);
            this.groupBox2.Controls.Add(this.cmbAy);
            this.groupBox2.Location = new System.Drawing.Point(446, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi kartı bilgilerinizi girin";
            // 
            // lblSKT
            // 
            this.lblSKT.AutoSize = true;
            this.lblSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSKT.Location = new System.Drawing.Point(33, 155);
            this.lblSKT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(139, 17);
            this.lblSKT.TabIndex = 2;
            this.lblSKT.Text = "Son Kullanma Tarihi:";
            this.lblSKT.Click += new System.EventHandler(this.lblSKT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toplam Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(407, 400);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(100, 26);
            this.txtTutar.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.SandyBrown;
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.SandyBrown;
            this.btnKaydet.BackColor = System.Drawing.Color.FloralWhite;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.ButtonText = "Kaydet";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnKaydet.IdleBorderThickness = 1;
            this.btnKaydet.IdleCornerRadius = 20;
            this.btnKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnKaydet.IdleForecolor = System.Drawing.Color.SaddleBrown;
            this.btnKaydet.IdleLineColor = System.Drawing.Color.Maroon;
            this.btnKaydet.Location = new System.Drawing.Point(699, 267);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 45);
            this.btnKaydet.TabIndex = 73;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnHemenOde
            // 
            this.btnHemenOde.ActiveBorderThickness = 1;
            this.btnHemenOde.ActiveCornerRadius = 20;
            this.btnHemenOde.ActiveFillColor = System.Drawing.Color.SandyBrown;
            this.btnHemenOde.ActiveForecolor = System.Drawing.Color.White;
            this.btnHemenOde.ActiveLineColor = System.Drawing.Color.SandyBrown;
            this.btnHemenOde.BackColor = System.Drawing.Color.FloralWhite;
            this.btnHemenOde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHemenOde.BackgroundImage")));
            this.btnHemenOde.ButtonText = "Hemen Öde";
            this.btnHemenOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHemenOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHemenOde.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnHemenOde.IdleBorderThickness = 1;
            this.btnHemenOde.IdleCornerRadius = 20;
            this.btnHemenOde.IdleFillColor = System.Drawing.Color.White;
            this.btnHemenOde.IdleForecolor = System.Drawing.Color.SaddleBrown;
            this.btnHemenOde.IdleLineColor = System.Drawing.Color.Maroon;
            this.btnHemenOde.Location = new System.Drawing.Point(398, 442);
            this.btnHemenOde.Margin = new System.Windows.Forms.Padding(4);
            this.btnHemenOde.Name = "btnHemenOde";
            this.btnHemenOde.Size = new System.Drawing.Size(109, 45);
            this.btnHemenOde.TabIndex = 74;
            this.btnHemenOde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHemenOde.Click += new System.EventHandler(this.btnHemenOde_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.ActiveBorderThickness = 1;
            this.btnGeriDon.ActiveCornerRadius = 20;
            this.btnGeriDon.ActiveFillColor = System.Drawing.Color.SandyBrown;
            this.btnGeriDon.ActiveForecolor = System.Drawing.Color.White;
            this.btnGeriDon.ActiveLineColor = System.Drawing.Color.SandyBrown;
            this.btnGeriDon.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeriDon.BackgroundImage")));
            this.btnGeriDon.ButtonText = "Geri Dön";
            this.btnGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGeriDon.IdleBorderThickness = 1;
            this.btnGeriDon.IdleCornerRadius = 20;
            this.btnGeriDon.IdleFillColor = System.Drawing.Color.White;
            this.btnGeriDon.IdleForecolor = System.Drawing.Color.SaddleBrown;
            this.btnGeriDon.IdleLineColor = System.Drawing.Color.Maroon;
            this.btnGeriDon.Location = new System.Drawing.Point(699, 442);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(149, 45);
            this.btnGeriDon.TabIndex = 75;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // Odeme_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(939, 516);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnHemenOde);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Odeme_Yap";
            this.Text = "Odeme_Yap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKrediKartNo;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYıl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTesvikRez;
        private System.Windows.Forms.RadioButton rbStandartRez;
        private System.Windows.Forms.RadioButton rb60GunOncedenRez;
        private System.Windows.Forms.RadioButton rbOnOdemeRez;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHemenOde;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGeriDon;
    }
}