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
    public partial class FormRezervasyon : MetroFramework.Forms.MetroForm
    {
        public FormRezervasyon()
        {
            InitializeComponent();
        }

        private DataTable dataTable = new DataTable();
        private void FormDenemeRezervasyon_Load(object sender, EventArgs e)
        {

            TabloyuOlustur();

            int satirSayisi = dataGridView1.Rows.Count;
            if (satirSayisi != 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            this.RezervasyonSayisiGetir();
            /*
            foreach(DataRow dr in dataTable.Rows)
            {
                //kullanım--> dr["AlanAdi"]
            }
            */
        }

        private void TabloyuOlustur()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                string query = "SELECT Adi+' '+Soyadi as Musteri_Bilgi,OdaNo,RezervasyonTarihi, Rezervasyonlar.id FROM Rezervasyonlar, Musteriler, Odalar WHERE Rezervasyonlar.MusteriId = Musteriler.id AND Rezervasyonlar.OdaId = Odalar.id";

                SqlCommand cmd = new SqlCommand(query, baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                baglanti.Close();
                da.Dispose();
                dataGridView1.DataSource = dataTable;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[0].Name = "BilgiColumn";
            dataGridView1.Columns[1].HeaderText = "Oda Numarası";
            dataGridView1.Columns[1].Name = "OdaNoColum";
            dataGridView1.Columns[2].HeaderText = "Rezervasyon Tarihi";
            dataGridView1.Columns[2].Name = "RezTarihColumn";

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[3].Name = "RezervasyonId";
          

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "iptal_buton";
            button.HeaderText = "";
            button.Text = "İptal Et";
            button.UseColumnTextForButtonValue = true; //dont forget this line

            this.dataGridView1.Columns.Add(button);
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["iptal_buton"].Index)
            {
                if (e.RowIndex != -1)
                {
                    DialogResult diyalogCevap;
                    diyalogCevap = MessageBox.Show("Bu rezervasyonu iptal etmek istiyor musun?", "Rezervasyon Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (diyalogCevap == DialogResult.OK)
                    {
                        using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
                        {

                            string query = "DELETE FROM Rezervasyonlar WHERE id=" + dataGridView1.Rows[e.RowIndex].Cells["RezervasyonId"].Value;

                            baglanti.Open();
                            using (SqlCommand cmd = new SqlCommand(query, baglanti))
                            {
                                cmd.ExecuteNonQuery();
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                            }

                            baglanti.Close();
                        }

                    }
                    else
                    {
                        //No delete
                    }

                    dataGridView1.Refresh();
                    this.RezervasyonSayisiGetir();
                }

            }
        }

        private void mtrBtnYenile_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.RemoveAt(4);
            
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
           TabloyuOlustur();

            int satirSayisi = dataGridView1.Rows.Count;
            if (satirSayisi != 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            this.RezervasyonSayisiGetir();
        }

        private void mtrBtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult form1Result;
            using (FormRezervasyonEkle frm = new FormRezervasyonEkle())
            {
                form1Result = frm.ShowDialog();
            }
            if (form1Result == DialogResult.OK)
            {
                dataGridView1.Columns.RemoveAt(4);

                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
                TabloyuOlustur();
            }

            int satirSayisi = dataGridView1.Rows.Count;
            if (satirSayisi != 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            this.RezervasyonSayisiGetir();
        }

        private void RezervasyonSayisiGetir()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                using (SqlCommand cmd = new SqlCommand("RezSayisiGetir", baglanti))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Donus", SqlDbType.Int);
                    cmd.Parameters["@Donus"].Direction = ParameterDirection.Output;
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    rezSayisi.Text = cmd.Parameters["@Donus"].Value.ToString();
                }
            }
        }
    }
}
