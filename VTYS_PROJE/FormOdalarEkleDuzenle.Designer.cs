namespace VTYS_PROJE
{
    partial class FormOdalarEkleDuzenle
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtOdaNo = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceOdalar = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKisiSayisi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboDurum = new MetroFramework.Controls.MetroComboBox();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtOdaTipi = new MetroFramework.Controls.MetroComboBox();
            this.uyariYazi = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(69, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Kişi Sayısı:";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOdalar, "OdaNo", true));
            this.txtOdaNo.Location = new System.Drawing.Point(140, 120);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(121, 28);
            this.txtOdaNo.TabIndex = 0;
            // 
            // bindingSourceOdalar
            // 
            this.bindingSourceOdalar.DataSource = typeof(VTYS_PROJE.Odalar);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Oda No:";
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOdalar, "OdaKisiSayisi", true));
            this.txtKisiSayisi.Location = new System.Drawing.Point(140, 165);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(121, 28);
            this.txtKisiSayisi.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 216);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Durumu:";
            // 
            // cboDurum
            // 
            this.cboDurum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOdalar, "OdaDurumu", true));
            this.cboDurum.FormattingEnabled = true;
            this.cboDurum.ItemHeight = 23;
            this.cboDurum.Items.AddRange(new object[] {
            "UYGUN",
            "DOLU",
            "TEMİZLİK GEREKİYOR",
            "ÇIKIŞ GECİKTİ"});
            this.cboDurum.Location = new System.Drawing.Point(140, 213);
            this.cboDurum.Name = "cboDurum";
            this.cboDurum.Size = new System.Drawing.Size(121, 29);
            this.cboDurum.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(151, 319);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(82, 34);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(69, 267);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Oda Tipi:";
            // 
            // txtOdaTipi
            // 
            this.txtOdaTipi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOdalar, "OdaTipi", true));
            this.txtOdaTipi.FormattingEnabled = true;
            this.txtOdaTipi.ItemHeight = 23;
            this.txtOdaTipi.Items.AddRange(new object[] {
            "STANDART",
            "PREMIUM",
            "VIP"});
            this.txtOdaTipi.Location = new System.Drawing.Point(140, 264);
            this.txtOdaTipi.Name = "txtOdaTipi";
            this.txtOdaTipi.Size = new System.Drawing.Size(121, 29);
            this.txtOdaTipi.TabIndex = 13;
            // 
            // uyariYazi
            // 
            this.uyariYazi.AutoSize = true;
            this.uyariYazi.CustomForeColor = true;
            this.uyariYazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.uyariYazi.Location = new System.Drawing.Point(138, 267);
            this.uyariYazi.Name = "uyariYazi";
            this.uyariYazi.Size = new System.Drawing.Size(128, 19);
            this.uyariYazi.TabIndex = 16;
            this.uyariYazi.Text = "Önce odayı ekleyiniz";
            // 
            // FormOdalarEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 376);
            this.Controls.Add(this.uyariYazi);
            this.Controls.Add(this.txtOdaTipi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cboDurum);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "FormOdalarEkleDuzenle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Oda Bilgisi";
            this.Load += new System.EventHandler(this.FormOdalarEkleDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOdalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtOdaNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtKisiSayisi;
        private System.Windows.Forms.BindingSource bindingSourceOdalar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboDurum;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox txtOdaTipi;
        private MetroFramework.Controls.MetroLabel uyariYazi;
    }
}