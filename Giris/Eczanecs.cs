using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.OleDb;

namespace Giris
{
    public partial class Eczanecs : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris.accdb;Persist Security Info=True;Jet OLEDB:Database Password=systemub");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter oda = new OleDbDataAdapter();
        DataSet ds = new DataSet();






        public Eczanecs()
        {
            InitializeComponent();
        }

        public int  sipar(String a,String b)
        {
            int art = 0;
            baglanti.Open();


            try
            {
                komut = new OleDbCommand("Select  kul_ad,sif from eczane where  kul_ad='" + EczaneKul.Text + "' and sif='" + EczaneSif.Text + "'", baglanti);
                OleDbDataReader dr = komut.ExecuteReader();
               
                while (dr.Read())
                {
                    String ar = dr["sif"].ToString();
                    String br = dr["kul_ad"].ToString();
                    art = art + 1;
                }
                baglanti.Close();
               
            }
            catch (Exception)
            {
                baglanti.Close();
                art = 0;
            }


            return art;
        }










    private void EczaneGir_Click(object sender, EventArgs e)
    {
        if (EczaneKul.Text == "" && EczaneSif.Text == "")
        {

            MessageBox.Show("Kullanıcı adı veya şifre kısmını boş bıraktınız !");
        }
        else {
               int  sonuc =sipar(EczaneKul.Text, EczaneSif.Text);
                if (sonuc != 0)
                {
                    
                    eczaneana aa = new eczaneana(EczaneKul.Text);
                    aa.Show();
                    

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış !");
                }

        }

    }
        

        private void EczaneSif_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Eczanecs_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click()
        {

        }

        private void bttn1_Click(object sender, EventArgs e)
        {
      
           
        }

        private void eczaneg_Click(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
