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
    public partial class FormOdaGirisiEkle : MetroFramework.Forms.MetroForm
    {
        public FormOdaGirisiEkle()
        {
            InitializeComponent();

            dateTimeGirisTarihi.MinDate = DateTime.Now;
            dateTimeGirisTarihi.MaxDate = DateTime.Now;
        }

        private void FormDenemeOdaGirisiEkle_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                string queryOdalar = "SELECT id,OdaNo FROM Odalar WHERE OdaDurumu  !='DOLU'";
                string queryMusteri = "SELECT  Adi + ' ' + Soyadi as Bilgi FROM Musteriler";

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

                while (sqlReader2.Read())
                {
                    comboBoxMusteri.Items.Add(sqlReader2["Bilgi"].ToString());
                }

                baglanti.Close();



            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxOdaNo.Text == "" || comboBoxMusteri.Text == "")
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

                    string query = "INSERT INTO OdaKayitlari (musteriId, odaId, girisTarihi,cikisTarihi)";
                    query += " VALUES (@MusteriId, @OdaId, @girisTarihi,@cikisTarihi)";

                    SqlCommand cmd = new SqlCommand(query, baglanti);


                    cmd.Parameters.AddWithValue("@MusteriId", Int32.Parse(musteriId));
                    cmd.Parameters.AddWithValue("@OdaId", Int32.Parse(odaId));
                    cmd.Parameters.AddWithValue("@girisTarihi", dateTimeGirisTarihi.Text);
                    cmd.Parameters.AddWithValue("@cikisTarihi", "-");

                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    string queryoda = "UPDATE Odalar SET OdaDurumu = 'DOLU' WHERE id=" + Int32.Parse(odaId);

                    baglanti.Open();
                    using (SqlCommand cmdoda = new SqlCommand(queryoda, baglanti))
                    {
                        cmdoda.ExecuteNonQuery();
                    }



                    //datagride satır ekle ve refresh et
                }

                DialogResult = DialogResult.OK;
            }
        }
    }
}
