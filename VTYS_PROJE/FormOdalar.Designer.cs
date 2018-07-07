namespace VTYS_PROJE
{
    partial class FormOdalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdalar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtrBtnKaydet = new MetroFramework.Controls.MetroTile();
            this.mtrBtnSil = new MetroFramework.Controls.MetroTile();
            this.mtrBtnDuzenle = new MetroFramework.Controls.MetroTile();
            this.mtrBtnEkle = new MetroFramework.Controls.MetroTile();
            this.mtrBtnYenile = new MetroFramework.Controls.MetroTile();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSourceOdalar = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxBosOda = new MetroFramework.Controls.MetroCheckBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaKisiSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // mtrBtnKaydet
            // 
            this.mtrBtnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mtrBtnKaydet.CustomForeColor = true;
            this.mtrBtnKaydet.Location = new System.Drawing.Point(596, 81);
            this.mtrBtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnKaydet.Name = "mtrBtnKaydet";
            this.mtrBtnKaydet.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnKaydet.Style = MetroFramework.MetroColorStyle.Green;
            this.mtrBtnKaydet.TabIndex = 10;
            this.mtrBtnKaydet.Text = "Kaydet";
            this.mtrBtnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnKaydet.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnKaydet.TileImage")));
            this.mtrBtnKaydet.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnKaydet.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnKaydet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnKaydet.UseTileImage = true;
            this.mtrBtnKaydet.Click += new System.EventHandler(this.mtrBtnKaydet_Click);
            // 
            // mtrBtnSil
            // 
            this.mtrBtnSil.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mtrBtnSil.CustomBackground = true;
            this.mtrBtnSil.CustomForeColor = true;
            this.mtrBtnSil.ForeColor = System.Drawing.Color.Crimson;
            this.mtrBtnSil.Location = new System.Drawing.Point(454, 81);
            this.mtrBtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnSil.Name = "mtrBtnSil";
            this.mtrBtnSil.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnSil.TabIndex = 11;
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
            this.mtrBtnDuzenle.Location = new System.Drawing.Point(304, 81);
            this.mtrBtnDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnDuzenle.Name = "mtrBtnDuzenle";
            this.mtrBtnDuzenle.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnDuzenle.TabIndex = 12;
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
            this.mtrBtnEkle.Location = new System.Drawing.Point(167, 81);
            this.mtrBtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnEkle.Name = "mtrBtnEkle";
            this.mtrBtnEkle.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnEkle.TabIndex = 13;
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
            this.mtrBtnYenile.Location = new System.Drawing.Point(24, 81);
            this.mtrBtnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.mtrBtnYenile.Name = "mtrBtnYenile";
            this.mtrBtnYenile.Size = new System.Drawing.Size(100, 77);
            this.mtrBtnYenile.TabIndex = 14;
            this.mtrBtnYenile.Text = "Yenile";
            this.mtrBtnYenile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtrBtnYenile.TileImage = ((System.Drawing.Image)(resources.GetObject("mtrBtnYenile.TileImage")));
            this.mtrBtnYenile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtrBtnYenile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrBtnYenile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrBtnYenile.UseTileImage = true;
            this.mtrBtnYenile.Click += new System.EventHandler(this.mtrBtnYenile_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.odaNoDataGridViewTextBoxColumn,
            this.odaKisiSayisiDataGridViewTextBoxColumn,
            this.odaTipiDataGridViewTextBoxColumn,
            this.odaDurumuDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSourceOdalar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(20, 187);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(699, 211);
            this.dataGridView.TabIndex = 15;
            // 
            // bindingSourceOdalar
            // 
            this.bindingSourceOdalar.DataSource = typeof(VTYS_PROJE.Odalar);
            // 
            // checkBoxBosOda
            // 
            this.checkBoxBosOda.AutoSize = true;
            this.checkBoxBosOda.Location = new System.Drawing.Point(596, 165);
            this.checkBoxBosOda.Name = "checkBoxBosOda";
            this.checkBoxBosOda.Size = new System.Drawing.Size(117, 15);
            this.checkBoxBosOda.TabIndex = 16;
            this.checkBoxBosOda.Text = "Boş odaları göster";
            this.checkBoxBosOda.UseVisualStyleBackColor = true;
            this.checkBoxBosOda.CheckedChanged += new System.EventHandler(this.checkBoxBosOda_CheckedChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.FillWeight = 45F;
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaKisiSayisiDataGridViewTextBoxColumn
            // 
            this.odaKisiSayisiDataGridViewTextBoxColumn.DataPropertyName = "OdaKisiSayisi";
            this.odaKisiSayisiDataGridViewTextBoxColumn.FillWeight = 45F;
            this.odaKisiSayisiDataGridViewTextBoxColumn.HeaderText = "Oda Kişi Sayısı";
            this.odaKisiSayisiDataGridViewTextBoxColumn.Name = "odaKisiSayisiDataGridViewTextBoxColumn";
            this.odaKisiSayisiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaTipiDataGridViewTextBoxColumn
            // 
            this.odaTipiDataGridViewTextBoxColumn.DataPropertyName = "OdaTipi";
            this.odaTipiDataGridViewTextBoxColumn.HeaderText = "Oda Tipi";
            this.odaTipiDataGridViewTextBoxColumn.Name = "odaTipiDataGridViewTextBoxColumn";
            this.odaTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaDurumuDataGridViewTextBoxColumn
            // 
            this.odaDurumuDataGridViewTextBoxColumn.DataPropertyName = "OdaDurumu";
            this.odaDurumuDataGridViewTextBoxColumn.HeaderText = "Oda Durumu";
            this.odaDurumuDataGridViewTextBoxColumn.Name = "odaDurumuDataGridViewTextBoxColumn";
            this.odaDurumuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormOdalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 418);
            this.Controls.Add(this.checkBoxBosOda);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mtrBtnKaydet);
            this.Controls.Add(this.mtrBtnSil);
            this.Controls.Add(this.mtrBtnDuzenle);
            this.Controls.Add(this.mtrBtnEkle);
            this.Controls.Add(this.mtrBtnYenile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOdalar";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ODALAR";
            this.Load += new System.EventHandler(this.FormOdalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOdalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtrBtnKaydet;
        private MetroFramework.Controls.MetroTile mtrBtnSil;
        private MetroFramework.Controls.MetroTile mtrBtnDuzenle;
        private MetroFramework.Controls.MetroTile mtrBtnEkle;
        private MetroFramework.Controls.MetroTile mtrBtnYenile;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSourceOdalar;
        private MetroFramework.Controls.MetroCheckBox checkBoxBosOda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaKisiSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaDurumuDataGridViewTextBoxColumn;
    }
}