namespace VTYS_PROJE
{
    partial class FormRezervasyonEkle
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
            this.dateTimeRezervasyon = new System.Windows.Forms.DateTimePicker();
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
            this.comboBoxOdaNo.Location = new System.Drawing.Point(176, 98);
            this.comboBoxOdaNo.Name = "comboBoxOdaNo";
            this.comboBoxOdaNo.Size = new System.Drawing.Size(201, 29);
            this.comboBoxOdaNo.TabIndex = 29;
            // 
            // comboBoxMusteri
            // 
            this.comboBoxMusteri.FormattingEnabled = true;
            this.comboBoxMusteri.ItemHeight = 23;
            this.comboBoxMusteri.Location = new System.Drawing.Point(176, 150);
            this.comboBoxMusteri.Name = "comboBoxMusteri";
            this.comboBoxMusteri.Size = new System.Drawing.Size(201, 29);
            this.comboBoxMusteri.TabIndex = 28;
            // 
            // dateTimeRezervasyon
            // 
            this.dateTimeRezervasyon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeRezervasyon.Location = new System.Drawing.Point(176, 211);
            this.dateTimeRezervasyon.Name = "dateTimeRezervasyon";
            this.dateTimeRezervasyon.Size = new System.Drawing.Size(201, 20);
            this.dateTimeRezervasyon.TabIndex = 23;
            this.dateTimeRezervasyon.Value = new System.DateTime(2017, 12, 9, 18, 51, 22, 0);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(239, 267);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(63, 22);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(111, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Müşteri :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 211);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Rezervasyon Tarihi :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(106, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Oda No :";
            // 
            // FormDenemeRezervasyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 348);
            this.Controls.Add(this.comboBoxOdaNo);
            this.Controls.Add(this.comboBoxMusteri);
            this.Controls.Add(this.dateTimeRezervasyon);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormDenemeRezervasyonEkle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Rezervasyon Ekle";
            this.Load += new System.EventHandler(this.FormDenemeRezervasyonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboBoxOdaNo;
        private MetroFramework.Controls.MetroComboBox comboBoxMusteri;
        private System.Windows.Forms.DateTimePicker dateTimeRezervasyon;
        private MetroFramework.Controls.MetroTile btnKaydet;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}