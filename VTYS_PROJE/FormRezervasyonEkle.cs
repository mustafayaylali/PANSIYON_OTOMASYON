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
    public partial class FormRezervasyonEkle : MetroFramework.Forms.MetroForm
    {
        public FormRezervasyonEkle()
        {
            InitializeComponent();

            dateTimeRezervasyon.MinDate = DateTime.Now;
            dateTimeRezervasyon.Value = dateTimeRezervasyon.MinDate;
        }

        private void FormDenemeRezervasyonEkle_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                string queryOdalar = "SELECT id,OdaNo FROM Odalar";
                string queryMusteri = "SELECT  Adi + ' ' + Soyadi as Bilgi FROM Musteriler b LEFT JOIN Rezervasyonlar o ON b.id = o.MusteriId WHERE o.MusteriId IS NULL";

                SqlCommand cmd = new SqlCommand(queryOdalar, baglanti);
                SqlCommand cmd2 = new SqlCommand(queryMusteri, baglanti);

                baglanti.Open();

                SqlDataReader sqlReader = cmd.ExecuteReader(); //odalar combobox a eklenir
       
                while (sqlReader.Read())
                {
                    comboBoxOdaNo.Items.Add(new { name = sqlReader["OdaNo"].ToString(), value = sqlReader["id"] });
                }

                comboBoxOdaNo.ValueMember = "value";
                comboBoxOdaNo.DisplayMember = "name";

                SqlDataReader sqlReader2 = cmd2.ExecuteReader(); //musteriler combobox a eklenir


                int kontrol = 0;
                while (sqlReader2.Read())
                {
                    kontrol = 1;
                    comboBoxMusteri.Items.Add(sqlReader2["Bilgi"].ToString());
                }

                baglanti.Close();

                //MessageBox.Show(comboBoxMusteri.Text);
                if (kontrol==0)
                {
                    MessageBox.Show("Tüm müşterilerin rezervasyonu var!");
                    DialogResult = DialogResult.OK;
                }
                

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

          if(comboBoxOdaNo.Text=="" || comboBoxMusteri.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz !");
            }
            else
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
                {

                    string queryMusteriId = "SELECT id FROM Musteriler WHERE Adi+' '+Soyadi=" + "'" + comboBoxMusteri.Text + "'";
                    string queryOdaId = "SELECT id FROM Odalar WHERE OdaNo=" + "'" + comboBoxOdaNo.Text + "'";

                    SqlCommand cmdMusteri = new SqlCommand(queryMusteriId, baglanti);
                    SqlCommand cmdOda = new SqlCommand(queryOdaId, baglanti);

                    baglanti.Open();

                    SqlDataReader dr = cmdMusteri.ExecuteReader();
                    SqlDataReader dr2 = cmdOda.ExecuteReader();

                    string musteriId = "";
                    while (dr.Read())
                    {
                        musteriId = dr[0].ToString();
                    }
                    string odaId = "";
                    while (dr2.Read())
                    {
                        odaId = dr2[0].ToString();
                    }

                    baglanti.Close();

                    string query = "INSERT INTO Rezervasyonlar (MusteriId, OdaId, RezervasyonTarihi)";
                    query += " VALUES (@MusteriId, @OdaId, @RezervasyonTarihi)";

                    SqlCommand cmd = new SqlCommand(query, baglanti);


                    cmd.Parameters.AddWithValue("@MusteriId", Int32.Parse(musteriId));
                    cmd.Parameters.AddWithValue("@OdaId", Int32.Parse(odaId));
                    cmd.Parameters.AddWithValue("@RezervasyonTarihi", dateTimeRezervasyon.Text);

                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();


                    //datagride satır ekle ve refresh et
                }

                DialogResult = DialogResult.OK;
            }
            

        }
    }
}
