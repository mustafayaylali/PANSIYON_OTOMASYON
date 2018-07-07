namespace VTYS_PROJE
{
    partial class FormMusteriEkleDuzenle
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriTc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriAd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMusteriSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePickerDt = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriTelNo = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new MetroFramework.Controls.MetroTile();
            this.bindingSourceMusteriler = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Müşteri ID:";
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMusteriler, "id", true));
            this.txtMusteriId.Enabled = false;
            this.txtMusteriId.Location = new System.Drawing.Point(154, 85);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(184, 23);
            this.txtMusteriId.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(102, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Adı:";
            // 
            // txtMusteriTc
            // 
            this.txtMusteriTc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMusteriler, "TcNo", true));
            this.txtMusteriTc.Location = new System.Drawing.Point(154, 126);
            this.txtMusteriTc.MaxLength = 11;
            this.txtMusteriTc.Name = "txtMusteriTc";
            this.txtMusteriTc.Size = new System.Drawing.Size(184, 23);
            this.txtMusteriTc.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(83, 218);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Soyadı:";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMusteriler, "Adi", true));
            this.txtMusteriAd.Location = new System.Drawing.Point(154, 172);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(184, 23);
            this.txtMusteriAd.TabIndex = 2;
            this.txtMusteriAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAd_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(89, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Tc No:";
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMusteriler, "Soyadi", true));
            this.txtMusteriSoyad.Location = new System.Drawing.Point(154, 214);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(184, 23);
            this.txtMusteriSoyad.TabIndex = 3;
            this.txtMusteriSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriSoyad_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(44, 264);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Doğum Tarihi:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 312);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(113, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Telefon Numarası:";
            // 
            // dateTimePickerDt
            // 
            this.dateTimePickerDt.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePickerDt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMusteriler, "DogumTarihi", true));
            this.dateTimePickerDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDt.Location = new System.Drawing.Point(154, 264);
            this.dateTimePickerDt.Name = "dateTimePickerDt";
            this.dateTimePickerDt.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerDt.TabIndex = 6;
            this.dateTimePickerDt.Value = new System.DateTime(1999, 12, 6, 0, 0, 0, 0);
            // 
            // txtMusteriTelNo
            // 
            this.txtMusteriTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMusteriTelNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMusteriler, "TelNo", true));
            this.txtMusteriTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTelNo.Location = new System.Drawing.Point(154, 312);
            this.txtMusteriTelNo.Mask = "(999) 000 00 00";
            this.txtMusteriTelNo.Name = "txtMusteriTelNo";
            this.txtMusteriTelNo.Size = new System.Drawing.Size(120, 15);
            this.txtMusteriTelNo.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(367, 346);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(62, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bindingSourceMusteriler
            // 
            this.bindingSourceMusteriler.DataSource = typeof(VTYS_PROJE.Musteriler);
            // 
            // FormMusteriEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 378);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMusteriTelNo);
            this.Controls.Add(this.dateTimePickerDt);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMusteriTc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "FormMusteriEkleDuzenle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Müşteri Bilgi";
            this.Load += new System.EventHandler(this.FormMusteriEkleDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMusteriId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMusteriTc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMusteriAd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMusteriSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.BindingSource bindingSourceMusteriler;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDt;
        private System.Windows.Forms.MaskedTextBox txtMusteriTelNo;
        private MetroFramework.Controls.MetroTile btnKaydet;
    }
}