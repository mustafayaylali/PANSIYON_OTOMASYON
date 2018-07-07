using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_PROJE
{
    public partial class FormMusteri : MetroFramework.Forms.MetroForm
    {
        public FormMusteri()
        {
            InitializeComponent();
        }

        private async void mtrBtnEkle_Click(object sender, EventArgs e)
        {
            using (FormMusteriEkleDuzenle frm = new FormMusteriEkleDuzenle(new Musteriler()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        musterilerBindingSource.Add(frm.MusteriBilgi);
                        db.Musteriler.Add(frm.MusteriBilgi);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    }
                }
            }
        }

        PansiyonDBEntities db;

        private void FormMusteri_Load(object sender, EventArgs e)
        {

            db = new PansiyonDBEntities();
            musterilerBindingSource.DataSource = db.Musteriler.ToList();

        }

        private void mtrBtnYenile_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            musterilerBindingSource.DataSource = db.Musteriler.ToList();
            Cursor.Current = Cursors.Default;
        }

        private async void mtrBtnDuzenle_Click(object sender, EventArgs e)
        {
            Musteriler obj = musterilerBindingSource.Current as Musteriler;
            if(obj != null)
            {
                using(FormMusteriEkleDuzenle frm=new FormMusteriEkleDuzenle(obj))
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            musterilerBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private async void mtrBtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğine emin misin?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                int rows = dataGridView1.RowCount;
                for(int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        db.Musteriler.Remove(dataGridView1.Rows[i].DataBoundItem as Musteriler);
                        musterilerBindingSource.RemoveAt(dataGridView1.Rows[i].Index);

                        musterilerBindingSource.EndEdit();
                        await db.SaveChangesAsync();
                    }
                }
            }
        }

        private void txtAraTc_KeyUp(object sender, KeyEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[1].Value.ToString();
                if (!s.StartsWith(txtAraTc.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
            
        }

        private void txtAraAd_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string ad = row.Cells[2].Value.ToString();
                string soyad = row.Cells[3].Value.ToString();
                if (!ad.StartsWith(txtAraAd.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }

        private void txtAraSoyad_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string ad = row.Cells[2].Value.ToString();
                string soyad = row.Cells[3].Value.ToString();
                if (!soyad.StartsWith(txtAraSoyad.Text, true, null))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                    row.Visible = true;
            }
        }
    }
}
