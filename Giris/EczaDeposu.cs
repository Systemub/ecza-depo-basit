using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Giris
{
    public partial class EczaDeposu : Form
    {
        SqlCommand komut;

        SqlConnection baglanti;
        

        SqlDataAdapter sda;

        bool baglan(string a,string b) {

            try {
                string BaglantiAdresi = "Server=.;Database=giris;User Id=" + a + ";Password=" + b + ";";
                baglanti = new SqlConnection(BaglantiAdresi);
                baglanti.Open();
                sda = new SqlDataAdapter("Select * From eczane", baglanti);
            }
            catch(Exception err)
            {
               
                return false;
              

            }
            baglanti.Close();
            return true;
        }



        public EczaDeposu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void eczadgeri_Click(object sender, EventArgs e)
        {
            Form1 cs = new Form1();
            this.Hide();
            cs.ShowDialog();
            this.Close();
        }

        private void depogbtn_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            bool s=baglan(a, b);
            if (s == true)
            {
                EczaDeposu1 cs = new EczaDeposu1();
                this.Hide();
                cs.ShowDialog();
                this.Close();
            }
            else {

                MessageBox.Show("Kullanıcı adı yada şifre yanlış", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }
    }
}
