namespace VTYS_PROJE
{
    partial class FormKasa
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
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtDetayGoster = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.White;
            this.txtToplam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToplam.Enabled = false;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtToplam.Location = new System.Drawing.Point(23, 154);
            this.txtToplam.MaxLength = 4;
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(426, 109);
            this.txtToplam.TabIndex = 2;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDetayGoster
            // 
            this.txtDetayGoster.CustomForeColor = true;
            this.txtDetayGoster.ForeColor = System.Drawing.Color.White;
            this.txtDetayGoster.Location = new System.Drawing.Point(335, 44);
            this.txtDetayGoster.Name = "txtDetayGoster";
            this.txtDetayGoster.Size = new System.Drawing.Size(124, 24);
            this.txtDetayGoster.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDetayGoster.TabIndex = 3;
            this.txtDetayGoster.Text = "Detay Göster";
            this.txtDetayGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDetayGoster.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtDetayGoster.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.txtDetayGoster.Click += new System.EventHandler(this.txtDetayGoster_Click);
            // 
            // FormKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 396);
            this.Controls.Add(this.txtDetayGoster);
            this.Controls.Add(this.txtToplam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKasa";
            this.Resizable = false;
            this.Text = "KASA";
            this.Load += new System.EventHandler(this.FormKasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToplam;
        private MetroFramework.Controls.MetroTile txtDetayGoster;
    }
}