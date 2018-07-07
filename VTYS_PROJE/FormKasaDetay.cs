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
    public partial class FormKasaDetay : MetroFramework.Forms.MetroForm
    {
        private DataTable dataTable = new DataTable();
        public FormKasaDetay()
        {
            InitializeComponent();

            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                string query = "SELECT Adi+' '+Soyadi,OdaNo,girisTarihi,cikisTarihi,gelir+' TL' FROM Kasa,OdaKayitlari,Musteriler,Odalar WHERE Kasa.OdaKayitId=OdaKayitlari.odaKayitId AND OdaKayitlari.musteriId=Musteriler.id AND OdaKayitlari.odaId=Odalar.id";

                SqlCommand cmd = new SqlCommand(query, baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                baglanti.Close();
                da.Dispose();
                dataGridView1.DataSource = dataTable;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Müşteri Adı Soyadı";
            dataGridView1.Columns[0].Name = "mColumn";
            dataGridView1.Columns[1].HeaderText = "Oda No";
            dataGridView1.Columns[1].Name = "oColum";
            dataGridView1.Columns[2].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns[2].Name = "gColum";
            dataGridView1.Columns[3].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns[3].Name = "gcColum";
            dataGridView1.Columns[4].HeaderText = "Gelir";
            dataGridView1.Columns[4].Name = "gelirColum";
        }
    }
}
