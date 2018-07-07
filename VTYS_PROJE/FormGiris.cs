using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_PROJE
{
    public partial class FormGiris : MetroFramework.Forms.MetroForm
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {

            using (FormMusteri frm = new FormMusteri())
            {
                frm.ShowDialog();
            }
        
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            using (FormOdalar frm = new FormOdalar())
            {
                frm.ShowDialog();
            }
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            using (FormRezervasyon frm = new FormRezervasyon())
            {
                frm.ShowDialog();
            }
        }

        private void kilitResim_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKilit frm = new FormKilit();
            frm.Show();
        }



        private void btnOdaGirisi_Click(object sender, EventArgs e)
        {
            using (FormOdaGirisi frm = new FormOdaGirisi())
            {
                frm.ShowDialog();
            }
        }

        private void kilitResim_MouseHover(object sender, EventArgs e)
        {
            this.kilitResim.BackColor = Color.Aqua;
        }

        private void kilitResim_MouseLeave(object sender, EventArgs e)
        {
            this.kilitResim.BackColor = DefaultBackColor;
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            using (FormKasa frm = new FormKasa())
            {
                frm.ShowDialog();
            }
        }

    }
}
