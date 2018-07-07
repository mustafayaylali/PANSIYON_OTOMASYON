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
    public partial class FormMusteriEkleDuzenle : MetroFramework.Forms.MetroForm
    {
        public FormMusteriEkleDuzenle(Musteriler obj)
        {
            InitializeComponent();
            bindingSourceMusteriler.DataSource = obj; //veriler alınır gösterilmek için

            dateTimePickerDt.MaxDate = DateTime.Now.AddYears(-18);
        }

        public Musteriler MusteriBilgi{get { return bindingSourceMusteriler.Current as Musteriler;}}

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtMusteriAd.Text=="" || txtMusteriSoyad.Text=="" || txtMusteriTc.Text=="" || txtMusteriTelNo.Text=="" || dateTimePickerDt.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz !");
            }
            else
            {
                bindingSourceMusteriler.EndEdit();
                DialogResult = DialogResult.OK;
            }

        }

        private void FormMusteriEkleDuzenle_Load(object sender, EventArgs e)
        {         
        }

        private void txtMusteriAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void txtMusteriSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
    }
}
