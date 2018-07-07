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
    public partial class FormOdalar : MetroFramework.Forms.MetroForm
    {
        public FormOdalar()
        {
            InitializeComponent();
        }

        private async void mtrBtnEkle_Click(object sender, EventArgs e)
        {
            
            using (FormOdalarEkleDuzenle frm = new FormOdalarEkleDuzenle(new Odalar()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bindingSourceOdalar.Add(frm.OdalarBilgi);
                        db.Odalar.Add(frm.OdalarBilgi);
                        await db.SaveChangesAsync();
                        this.Renklendir();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        PansiyonDBEntities db;

        private void mtrBtnYenile_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceOdalar.DataSource = db.Odalar.ToList();
            this.Renklendir();
            Cursor.Current = Cursors.Default;

        }

        private void FormOdalar_Load(object sender, EventArgs e)
        {
            db = new PansiyonDBEntities();
            bindingSourceOdalar.DataSource = db.Odalar.ToList();
            this.Renklendir();

            //dataGridView.Columns.Add("Column", "Test");     //this.dataGridView1.Columns.Add(ColumnName, HeaderText);
        }

        private void Renklendir()
        {
            int satirSayisi = dataGridView.Rows.Count;
            for (int i = 0; i < satirSayisi; i++)
            {
                if (dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Value.ToString() == "DOLU")
                {
                    dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
                }
                else if (dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Value.ToString() == "UYGUN")
                {
                    dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Style.BackColor = Color.Green;
                }
                else if (dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Value.ToString() == "TEMİZLİK GEREKİYOR")
                {
                    dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Style.BackColor = Color.Yellow;
                }
                else if (dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Value.ToString() == "ÇIKIŞ GECİKTİ")
                {
                    dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Style.BackColor = Color.DodgerBlue;
                }

                if (dataGridView.Rows[i].Cells["odaTipiDataGridViewTextBoxColumn"].Value == null)
                {
                    dataGridView.Rows[i].Cells["odaTipiDataGridViewTextBoxColumn"].Style.BackColor = Color.Pink;
                }
                

            }
        }

        private async void mtrBtnDuzenle_Click(object sender, EventArgs e)
        {
            Odalar obj = bindingSourceOdalar.Current as Odalar;
            if (obj != null)
            {
                using (FormOdalarEkleDuzenle frm = new FormOdalarEkleDuzenle(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            bindingSourceOdalar.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void mtrBtnSil_Click(object sender, EventArgs e)
        {
            int ykoordinat = dataGridView.CurrentCellAddress.Y;  //Seçili satırın Y koordinati
         
            if (MessageBox.Show(dataGridView.Rows[ykoordinat].Cells[1].Value.ToString()+" Numaralı odayı silmek istediğine emin misin?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Odalar.Remove(dataGridView.Rows[ykoordinat].DataBoundItem as Odalar);
                bindingSourceOdalar.RemoveAt(dataGridView.Rows[ykoordinat].Index);
            }
        }

        private async void mtrBtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Kaydetmek istediğine emin misin?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingSourceOdalar.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxBosOda_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxBosOda.Checked == true)
            {
                int satirSayisi = dataGridView.Rows.Count;

                for (int i = 0; i < satirSayisi; i++)
                {
                    dataGridView.CurrentCell = null;

                    if (dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Value.ToString() != "UYGUN")
                    {
                        dataGridView.Rows[i].Visible = false; //ilk satır dolu ise seçili oldugu için gizlemiyor
                    }
                }
            }
            else
            {
                int satirSayisi = dataGridView.Rows.Count;
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (dataGridView.Rows[i].Cells["odaDurumuDataGridViewTextBoxColumn"].Value.ToString() != "UYGUN")
                    {
                        dataGridView.Rows[i].Visible = true;
                    }
                }
            }
            
        }
    }
}
