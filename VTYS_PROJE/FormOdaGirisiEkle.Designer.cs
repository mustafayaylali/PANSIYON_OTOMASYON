namespace VTYS_PROJE
{
    partial class FormOdaGirisiEkle
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
            this.comboBoxOdaNo = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxMusteri = new MetroFramework.Controls.MetroComboBox();
            this.dateTimeGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // comboBoxOdaNo
            // 
            this.comboBoxOdaNo.FormattingEnabled = true;
            this.comboBoxOdaNo.ItemHeight = 23;
            this.comboBoxOdaNo.Location = new System.Drawing.Point(189, 106);
            this.comboBoxOdaNo.Name = "comboBoxOdaNo";
            this.comboBoxOdaNo.Size = new System.Drawing.Size(121, 29);
            this.comboBoxOdaNo.TabIndex = 38;
            // 
            // comboBoxMusteri
            // 
            this.comboBoxMusteri.FormattingEnabled = true;
            this.comboBoxMusteri.ItemHeight = 23;
            this.comboBoxMusteri.Location = new System.Drawing.Point(189, 158);
            this.comboBoxMusteri.Name = "comboBoxMusteri";
            this.comboBoxMusteri.Size = new System.Drawing.Size(121, 29);
            this.comboBoxMusteri.TabIndex = 37;
            // 
            // dateTimeGirisTarihi
            // 
            this.dateTimeGirisTarihi.Enabled = false;
            this.dateTimeGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeGirisTarihi.Location = new System.Drawing.Point(189, 219);
            this.dateTimeGirisTarihi.Name = "dateTimeGirisTarihi";
            this.dateTimeGirisTarihi.Size = new System.Drawing.Size(121, 20);
            this.dateTimeGirisTarihi.TabIndex = 31;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(189, 283);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 42);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(124, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Müşteri :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(108, 219);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Giriş Tarihi :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(119, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Oda No :";
            // 
            // FormOdaGirisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 354);
            this.Controls.Add(this.comboBoxOdaNo);
            this.Controls.Add(this.comboBoxMusteri);
            this.Controls.Add(this.dateTimeGirisTarihi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormOdaGirisiEkle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "ODAYA MÜŞTERİ GİRİŞİ";
            this.Load += new System.EventHandler(this.FormDenemeOdaGirisiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboBoxOdaNo;
        private MetroFramework.Controls.MetroComboBox comboBoxMusteri;
        private System.Windows.Forms.DateTimePicker dateTimeGirisTarihi;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}