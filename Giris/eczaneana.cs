using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Giris
{
    public partial class eczaneana : Form
    {


        String eczaneadi;
        public eczaneana()
        {
            InitializeComponent();
        }
        public eczaneana(string a) {
            InitializeComponent();
            eczaneadi = a;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris.accdb;Persist Security Info=True;Jet OLEDB:Database Password=systemub");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter oda = new OleDbDataAdapter();
        DataSet ds = new DataSet();


        private void eczaneana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'girisDataSet.ilac' table. You can move, or remove it, as needed.
            this.ilacTableAdapter.Fill(this.girisDataSet.ilac);
            // TODO: This line of code loads data into the 'girisDataSet.ilac' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {

           int a = (int)Convert.ToUInt32(adetil.Text);
            

            baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into ecz_sipar (eczane_adi,ilac_adi,adet,istek) values ('"+eczaneadi+"','"+ilacadi.Text+ "','" + a + "',true)";
                komut.ExecuteScalar();
                baglanti.Close();
          
        }

        private void ilacadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select  adet,adet_ucret from ilac where ilac_adi='" + ilacadi.Text + "'", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                fiyat.Text = dr["adet_ucret"].ToString();
                stokdurum.Text = dr["adet"].ToString();

            }
            baglanti.Close();

        }
    }
}
