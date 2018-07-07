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
    public partial class FormOdalarEkleDuzenle : MetroFramework.Forms.MetroForm
    {

        public int odaId;
        public FormOdalarEkleDuzenle(Odalar obj)
        {
           
            InitializeComponent();
            bindingSourceOdalar.DataSource = obj;

            
            if (obj.id == 0)
            {
                txtOdaTipi.Visible = false;
                uyariYazi.Visible = true;
            }
            else
            {
                txtOdaTipi.Visible = true;
                uyariYazi.Visible = false;
                odaId = obj.id;
            }


        }

        public Odalar OdalarBilgi { get { return bindingSourceOdalar.Current as Odalar; } }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtOdaNo.Text=="" || txtKisiSayisi.Text == "" || cboDurum.Text == "" )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz !");
            }
            else
            {              
                    bindingSourceOdalar.EndEdit();
                    DialogResult = DialogResult.OK;

                using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
                {
                    

                    if (txtOdaTipi.Text == "STANDART" && txtOdaTipi.Visible==true)  //sıradaki id yi getirip kalıtım tablosuna ekleme yapar
                    {                       
                        using (SqlCommand cmd = new SqlCommand("standartOdaEkle", baglanti))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OdaId", odaId); //sıradaki id EKLENMİYOR. önce bu sonra odalar ekleniyor 
                            cmd.Parameters.AddWithValue("@Ucret", "50");
                            baglanti.Open();
                            cmd.ExecuteNonQuery();
                            baglanti.Close();
                        }
                    }
                    else if (txtOdaTipi.Text == "PREMIUM" && txtOdaTipi.Visible == true)  //sıradaki id yi getirip kalıtım tablosuna ekleme yapar
                    {
                        using (SqlCommand cmd = new SqlCommand("premiumOdaEkle", baglanti))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OdaId", odaId); //sıradaki id EKLENMİYOR. önce bu sonra odalar ekleniyor 
                            cmd.Parameters.AddWithValue("@Ucret", "100");
                            baglanti.Open();
                            cmd.ExecuteNonQuery();
                            baglanti.Close();
                        }
                    }
                    else if (txtOdaTipi.Text == "VIP" && txtOdaTipi.Visible == true)  //sıradaki id yi getirip kalıtım tablosuna ekleme yapar
                    {
                        using (SqlCommand cmd = new SqlCommand("vipOdaEkle", baglanti))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@OdaId", odaId); //sıradaki id EKLENMİYOR. önce bu sonra odalar ekleniyor 
                            cmd.Parameters.AddWithValue("@Ucret", "200");
                            baglanti.Open();
                            cmd.ExecuteNonQuery();
                            baglanti.Close();
                        }
                    }
                }
            }
                    }

        private void FormOdalarEkleDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}