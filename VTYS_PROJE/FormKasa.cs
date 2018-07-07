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
    public partial class FormKasa : MetroFramework.Forms.MetroForm
    {
        public FormKasa()
        {
            InitializeComponent();
        }


        private void FormKasa_Load(object sender, EventArgs e)
        {
            this.KasaToplamGetir();
        }

        private void KasaToplamGetir()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA-PC\\SQLEXPRESS;Initial Catalog=PansiyonDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                using (SqlCommand cmd = new SqlCommand("[KasaToplamGetir]", baglanti))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Donus", SqlDbType.Int);
                    cmd.Parameters["@Donus"].Direction = ParameterDirection.Output;
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    if (cmd.Parameters["@Donus"].Value.ToString() == "")
                    {
                        txtToplam.Text = "0 TL";
                    }
                    else
                    {
                        txtToplam.Text = cmd.Parameters["@Donus"].Value.ToString() + " TL";
                    }
                    
                }
            }
        }

        private void txtDetayGoster_Click(object sender, EventArgs e)
        {
            using(FormKasaDetay frm=new FormKasaDetay())
            {
                frm.ShowDialog();
            }
        }
    }
}
