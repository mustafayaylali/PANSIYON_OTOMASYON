namespace VTYS_PROJE
{
    partial class FormOdaGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdaGirisi));
            this.rezSayisi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtrBtnEkle = new MetroFramework.Controls.MetroTile();
            this.mtrBtnYenile = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxAktifKayitlar = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rezSayisi
            // 
            this.rezSayisi.AutoSize = true;
            this.rezSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rezSayisi.CustomForeColor = true;
            this.rezSayisi.ForeColor = System.Drawing.Color.Maroon;
            this.rezSayisi.Location = new System.Drawing.Point(162, 165);
            this.rezSayisi.Name = "rezSayisi";
            this.rezSayisi.Size = new System.Drawing.Size(15, 19);
            this.rezSayisi.TabIndex = 26;
            this.rezSayisi.Text = "?";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.metroLabel1.Location = new System.Drawing.Point(35, 165);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Toplam Kayıt Sayısı:";
            // 
            // mtrBtnEkle
            // 
            this.mtrBtnEkle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mtrBtnEkle.CustomBackground = true;
            this.mtrBtnEkle.CustomForeColor = true;
            this.mtrBtnEkle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.mtrBtnEkle.Location = new System.Drawing.Point(419, 81);
            this.mtrBtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnEkle.Name = "mtrBtnEkle";
            this.mtrBtnEkle.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnEkle.TabIndex = 24;
            this.mtrBtnEkle.Text = "Ekle";
            this.mtrBtnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnEkle.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnEkle.TileImage")));
            this.mtrBtnEkle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnEkle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnEkle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnEkle.UseTileImage = true;
            this.mtrBtnEkle.Click += new System.EventHandler(this.mtrBtnEkle_Click);
            // 
            // mtrBtnYenile
            // 
            this.mtrBtnYenile.BackColor = System.Drawing.Color.Wheat;
            this.mtrBtnYenile.CustomBackground = true;
            this.mtrBtnYenile.CustomForeColor = true;
            this.mtrBtnYenile.ForeColor = System.Drawing.Color.ForestGreen;
            this.mtrBtnYenile.Location = new System.Drawing.Point(276, 81);
            this.mtrBtnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnYenile.Name = "mtrBtnYenile";
            this.mtrBtnYenile.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnYenile.TabIndex = 23;
            this.mtrBtnYenile.Text = "Yenile";
            this.mtrBtnYenile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnYenile.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnYenile.TileImage")));
            this.mtrBtnYenile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnYenile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnYenile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnYenile.UseTileImage = true;
            this.mtrBtnYenile.Click += new System.EventHandler(this.mtrBtnYenile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(20, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(711, 224);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // checkBoxAktifKayitlar
            // 
            this.checkBoxAktifKayitlar.AutoSize = true;
            this.checkBoxAktifKayitlar.Location = new System.Drawing.Point(591, 169);
            this.checkBoxAktifKayitlar.Name = "checkBoxAktifKayitlar";
            this.checkBoxAktifKayitlar.Size = new System.Drawing.Size(128, 15);
            this.checkBoxAktifKayitlar.TabIndex = 28;
            this.checkBoxAktifKayitlar.Text = "Tüm kayıtları göster";
            this.checkBoxAktifKayitlar.UseVisualStyleBackColor = true;
            this.checkBoxAktifKayitlar.CheckedChanged += new System.EventHandler(this.checkBoxAktifKayitlar_CheckedChanged);
            // 
            // FormOdaGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxAktifKayitlar);
            this.Controls.Add(this.rezSayisi);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtrBtnEkle);
            this.Controls.Add(this.mtrBtnYenile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOdaGirisi";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ODA KAYITLARI";
            this.Load += new System.EventHandler(this.FormDenemeOdaGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel rezSayisi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtrBtnEkle;
        private MetroFramework.Controls.MetroTile mtrBtnYenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroCheckBox checkBoxAktifKayitlar;
    }
}