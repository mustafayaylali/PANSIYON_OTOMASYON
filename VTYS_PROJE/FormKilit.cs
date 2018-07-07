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
    public partial class FormKilit : MetroFramework.Forms.MetroForm
    {
        public FormKilit()
        {
            InitializeComponent();
            
        }

        public string sifre = "5595";
        public string girilenSifre = "";

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //textBoxa metin girişini engelledik.
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textBoxPin.BackColor = Color.Orange;
            }
            else
            {
                textBoxPin.BackColor = Color.White;
                e.Handled = false;
                girilenSifre = girilenSifre + (e.KeyChar).ToString();
            }
        }

        private void textBoxPin_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (girilenSifre.Length == 4)
            {                
                if (girilenSifre == sifre)
                {
                    this.Hide();
                    FormGiris frm = new FormGiris();
                    frm.Show();

                }
                else
                {
                    textBoxPin.Text = "";
                    girilenSifre = "";
                    //kırmızı yap textbox arkaplanı
                    textBoxPin.BackColor = Color.Red;
                
                }
            }
        }

    }
}
