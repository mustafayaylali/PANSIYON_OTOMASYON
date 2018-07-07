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
    public partial class FormOdaGirisi : MetroFramework.Forms.MetroForm
    {
        public FormOdaGirisi()
        {
            InitializeComponent();
        }
        private DataTable dataTable = new DataTable();
        
        private void FormDenemeOdaGirisi_Load(object sender, EventArgs e)
        {
            TabloyuOlustur();

            int satirSayisi = dataGridView1.Rows.Count;
            if (satirSayisi != 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            this.OdaKayitiSayisiGetir();
        }

        private void TabloyuOlustur()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                string query = "SELECT OdaNo,Adi+' '+Soyadi as Musteri_Bilgi,girisTarihi, cikisTarihi, OdaKayitlari.odaKayitId FROM OdaKayitlari, Musteriler, Odalar WHERE OdaKayitlari.musteriId = Musteriler.id AND OdaKayitlari.OdaId = Odalar.id";

                SqlCommand cmd = new SqlCommand(query, baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                baglanti.Close();
                da.Dispose();
                dataGridView1.DataSource = dataTable;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Oda Numarası";
            dataGridView1.Columns[0].Name = "OdaNumarasi";
            dataGridView1.Columns[1].HeaderText = "Müşteri Bilgisi";
            dataGridView1.Columns[1].Name = "Mbilgi";
            dataGridView1.Columns[2].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns[2].Name = "GirisTarihi";
            dataGridView1.Columns[3].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns[3].Name = "CikisTarihi";
            
            dataGridView1.Columns[4].Name = "OdaKayitId";
            dataGridView1.Columns[4].Visible = false;

            //dataGridView1.Columns.Add("Odass", "Test");

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "sil_buton";
            button.HeaderText = "";
            button.Text = "Çıkış yap";
            button.UseColumnTextForButtonValue = true;

            this.dataGridView1.Columns.Add(button);

            //dataGridView1.Columns[5].Name = "butonColumn";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CikisTarihi"].Value.ToString() != "-")
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[row.Index].Visible=false;
                }
            }
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBoxAktifKayitlar.Checked == false)
            {     
                if (e.ColumnIndex == dataGridView1.Columns["sil_buton"].Index)
            {
                if (e.RowIndex != -1)
                {
                    DialogResult diyalogCevap;
                    diyalogCevap = MessageBox.Show("Bu odadan müşteri çıkışı yapmak istiyor musunuz?", "Oda çıkış işlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (diyalogCevap == DialogResult.OK)
                    {
                        using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
                        {
                            string tarih = DateTime.Now.ToShortDateString();

                           string query2 = "UPDATE OdaKayitlari SET cikisTarihi='"+tarih+"' WHERE odaKayitId=" + dataGridView1.Rows[e.RowIndex].Cells["odaKayitId"].Value;
                           string queryoda = "UPDATE Odalar SET OdaDurumu = 'TEMİZLİK GEREKİYOR' WHERE OdaNo=" + dataGridView1.Rows[e.RowIndex].Cells["OdaNumarasi"].Value;

                            baglanti.Open();
                          using (SqlCommand cmdoda = new SqlCommand(queryoda, baglanti))
                          {
                                    cmdoda.ExecuteNonQuery();
                          }
                                using (SqlCommand cmd = new SqlCommand(query2, baglanti))
                            {
                                cmd.ExecuteNonQuery();
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                yenile();

                            }


                                baglanti.Close();
                        }

                    }
                    else
                    {
                        //No delete
                    }

                    dataGridView1.Refresh();
                    this.OdaKayitiSayisiGetir();
                }

            }
            }
        }

        private void mtrBtnYenile_Click(object sender, EventArgs e)
        {
            yenile();
        }
        private void yenile()
        {
            dataGridView1.Columns.RemoveAt(5);

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
            this.OdaKayitiSayisiGetir();
        }

        private void mtrBtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult form1Result;
            using (FormOdaGirisiEkle frm = new FormOdaGirisiEkle())
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
            this.OdaKayitiSayisiGetir();
        }

        private void OdaKayitiSayisiGetir()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                using (SqlCommand cmd = new SqlCommand("OdaKayitiSayisiGetir", baglanti))
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



        private void checkBoxAktifKayitlar_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBoxAktifKayitlar.Checked == true)
            {
                dataGridView1.Columns.RemoveAt(5);

                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }

                TumKayitlarTablosuOlustur();
                mtrBtnEkle.Visible = false;
                mtrBtnYenile.Visible = false;
            }
            else
            {
                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }

                TabloyuOlustur();

                mtrBtnEkle.Visible = true;
                mtrBtnYenile.Visible = true;

                
            }

            int satirSayisi = dataGridView1.Rows.Count;
            if (satirSayisi != 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            this.OdaKayitiSayisiGetir();
        }

        private void TumKayitlarTablosuOlustur()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                string query = "SELECT OdaNo,Adi+' '+Soyadi as Musteri_Bilgi,girisTarihi, cikisTarihi, OdaKayitlari.odaKayitId FROM OdaKayitlari, Musteriler, Odalar WHERE OdaKayitlari.musteriId = Musteriler.id AND OdaKayitlari.OdaId = Odalar.id";

                SqlCommand cmd = new SqlCommand(query, baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                baglanti.Close();
                da.Dispose();
                dataGridView1.DataSource = dataTable;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Oda Numarası";
            dataGridView1.Columns[0].Name = "OdaNumarası";
            dataGridView1.Columns[1].HeaderText = "Müşteri Bilgisi";
            dataGridView1.Columns[1].Name = "Mbilgi";
            dataGridView1.Columns[2].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns[2].Name = "GirisTarihi";
            dataGridView1.Columns[3].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns[3].Name = "CikisTarihi";

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[4].Name = "OdaKayitId";
      

        }
    }
}
