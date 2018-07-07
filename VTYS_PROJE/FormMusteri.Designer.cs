namespace VTYS_PROJE
{
    partial class FormMusteri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtrBtnSil = new MetroFramework.Controls.MetroTile();
            this.mtrBtnDuzenle = new MetroFramework.Controls.MetroTile();
            this.mtrBtnEkle = new MetroFramework.Controls.MetroTile();
            this.mtrBtnYenile = new MetroFramework.Controls.MetroTile();
            this.txtAraTc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAraAd = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtAraSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tcNoDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.DogumTarihi,
            this.TelNo});
            this.dataGridView1.DataSource = this.musterilerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(27, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(781, 271);
            this.dataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.FillWeight = 79.94924F;
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "Tc No";
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            this.tcNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.FillWeight = 79.94924F;
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.FillWeight = 79.94924F;
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            this.soyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "DogumTarihi";
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            // 
            // TelNo
            // 
            this.TelNo.DataPropertyName = "TelNo";
            this.TelNo.FillWeight = 87.94417F;
            this.TelNo.HeaderText = "Telefon";
            this.TelNo.Name = "TelNo";
            this.TelNo.ReadOnly = true;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataSource = typeof(VTYS_PROJE.Musteriler);
            // 
            // mtrBtnSil
            // 
            this.mtrBtnSil.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mtrBtnSil.CustomBackground = true;
            this.mtrBtnSil.CustomForeColor = true;
            this.mtrBtnSil.ForeColor = System.Drawing.Color.Crimson;
            this.mtrBtnSil.Location = new System.Drawing.Point(586, 75);
            this.mtrBtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnSil.Name = "mtrBtnSil";
            this.mtrBtnSil.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnSil.TabIndex = 3;
            this.mtrBtnSil.Text = "Sil";
            this.mtrBtnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnSil.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnSil.TileImage")));
            this.mtrBtnSil.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnSil.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnSil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnSil.UseTileImage = true;
            this.mtrBtnSil.Click += new System.EventHandler(this.mtrBtnSil_Click);
            // 
            // mtrBtnDuzenle
            // 
            this.mtrBtnDuzenle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mtrBtnDuzenle.CustomBackground = true;
            this.mtrBtnDuzenle.CustomForeColor = true;
            this.mtrBtnDuzenle.ForeColor = System.Drawing.Color.Olive;
            this.mtrBtnDuzenle.Location = new System.Drawing.Point(436, 75);
            this.mtrBtnDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnDuzenle.Name = "mtrBtnDuzenle";
            this.mtrBtnDuzenle.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnDuzenle.TabIndex = 2;
            this.mtrBtnDuzenle.Text = "Düzenle";
            this.mtrBtnDuzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnDuzenle.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnDuzenle.TileImage")));
            this.mtrBtnDuzenle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnDuzenle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnDuzenle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnDuzenle.UseTileImage = true;
            this.mtrBtnDuzenle.Click += new System.EventHandler(this.mtrBtnDuzenle_Click);
            // 
            // mtrBtnEkle
            // 
            this.mtrBtnEkle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mtrBtnEkle.CustomBackground = true;
            this.mtrBtnEkle.CustomForeColor = true;
            this.mtrBtnEkle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.mtrBtnEkle.Location = new System.Drawing.Point(299, 75);
            this.mtrBtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnEkle.Name = "mtrBtnEkle";
            this.mtrBtnEkle.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnEkle.TabIndex = 1;
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
            this.mtrBtnYenile.Location = new System.Drawing.Point(156, 75);
            this.mtrBtnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnYenile.Name = "mtrBtnYenile";
            this.mtrBtnYenile.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnYenile.TabIndex = 0;
            this.mtrBtnYenile.Text = "Yenile";
            this.mtrBtnYenile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnYenile.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnYenile.TileImage")));
            this.mtrBtnYenile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnYenile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnYenile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnYenile.UseTileImage = true;
            this.mtrBtnYenile.Click += new System.EventHandler(this.mtrBtnYenile_Click);
            // 
            // txtAraTc
            // 
            this.txtAraTc.Location = new System.Drawing.Point(74, 3);
            this.txtAraTc.MaxLength = 11;
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(89, 23);
            this.txtAraTc.TabIndex = 6;
            this.txtAraTc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAraTc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAraTc_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(23, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Tc No:";
            // 
            // txtAraAd
            // 
            this.txtAraAd.Location = new System.Drawing.Point(232, 3);
            this.txtAraAd.MaxLength = 25;
            this.txtAraAd.Name = "txtAraAd";
            this.txtAraAd.Size = new System.Drawing.Size(126, 23);
            this.txtAraAd.TabIndex = 6;
            this.txtAraAd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAraAd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAraAd_KeyUp);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.txtAraSoyad);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtAraAd);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtAraTc);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(105, 167);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(622, 34);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtAraSoyad
            // 
            this.txtAraSoyad.Location = new System.Drawing.Point(443, 3);
            this.txtAraSoyad.MaxLength = 25;
            this.txtAraSoyad.Name = "txtAraSoyad";
            this.txtAraSoyad.Size = new System.Drawing.Size(126, 23);
            this.txtAraSoyad.TabIndex = 6;
            this.txtAraSoyad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAraSoyad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAraSoyad_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel4.Location = new System.Drawing.Point(386, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Soyadı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel2.Location = new System.Drawing.Point(194, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Adı:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel3.Location = new System.Drawing.Point(51, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "ARA:";
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 522);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtrBtnSil);
            this.Controls.Add(this.mtrBtnDuzenle);
            this.Controls.Add(this.mtrBtnEkle);
            this.Controls.Add(this.mtrBtnYenile);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMusteri";
            this.Padding = new System.Windows.Forms.Padding(27, 79, 27, 26);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MÜŞTERİLER";
            this.Load += new System.EventHandler(this.FormMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtrBtnSil;
        private MetroFramework.Controls.MetroTile mtrBtnDuzenle;
        private MetroFramework.Controls.MetroTile mtrBtnEkle;
        private MetroFramework.Controls.MetroTile mtrBtnYenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelNo;
        private MetroFramework.Controls.MetroTextBox txtAraTc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAraAd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAraSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}