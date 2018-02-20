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
    public partial class EczaDeposu1 : Form
    {


        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=giris.accdb;Persist Security Info=True;Jet OLEDB:Database Password=systemub");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        OleDbDataAdapter oda = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private Point mouseOffset;
        private bool isMouseDown = false;
        public EczaDeposu1()
        {
            InitializeComponent();
        }


    

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eczanelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        void siparisdurumu()
        {


            baglanti.Open();


            try
            {
                komut = new OleDbCommand("Select  * from ecz_sipar where istek=true", baglanti);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    siparischeck.Checked = true;
                    /* goster.Visible = true;
                   ilal.Hide();
                    ilsat.Hide();
                    Bilgi.Hide();
                    eczsilgb.Hide();
                    ecz_ekle.Hide();
                    eczduzenle.Hide();
                    eczkulgenel.Hide();
                    ilacbil.Hide();
                    */

                }



            }
            catch (Exception)
            {



            }
            baglanti.Close();
        }



        void siparis() {



            baglanti.Open();
            
            
            try
            {
                komut = new OleDbCommand("Select  * from ecz_sipar where istek=true", baglanti);
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {

                    String a = dr["eczane_adi"].ToString();

                  //  comboBox1.Text = dr["eczane_adi"].ToString();
                    ilal.Hide();
                    ilsatdurumu.Hide();
                    kasadurum.Hide();
                    ilsat.Show();
                    Bilgi.Hide();
                    eczsilgb.Hide();
                    ecz_ekle.Hide();
                    eczduzenle.Hide();
                    ilacbil.Show();
                    this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);
                    this.eczaneTableAdapter.Fill(this.girisDataSet.eczane);
                    this.ilacTableAdapter.Fill(this.girisDataSet.ilac);

                }
            }
            catch (Exception) {
             
            }
            baglanti.Close();
          


        }

        private void eczaneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasadurum.Hide();
            ilsatdurumu.Hide();
            ilacbil.Hide();
            ilal.Hide();
            ilsat.Hide();
            Bilgi.Hide();
            eczsilgb.Hide();
            ecz_ekle.Show();
            eczduzenle.Hide();
            eczkulgenel.Show();
            this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);
            this.eczaneTableAdapter.Fill(this.girisDataSet.eczane);
            this.ilacTableAdapter.Fill(this.girisDataSet.ilac);
        }

        private void eczaneCikarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasadurum.Hide();
            ilsatdurumu.Hide();
            ilal.Hide();
            ilsat.Hide();
            Bilgi.Hide();

            eczsilgb.Show();
            ilacbil.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Show();
            this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);
            this.eczaneTableAdapter.Fill(this.girisDataSet.eczane);
            this.ilacTableAdapter.Fill(this.girisDataSet.ilac);

        }

        private void ilaçDurumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilal.Hide();
            ilsat.Hide();
            Bilgi.Hide();
            eczsilgb.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Hide();
            ilacbil.Hide();
            ilsatdurumu.Show();
            kasadurum.Hide();

        }
      
        private void EczaDeposu1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'girisDataSet.kasa1' table. You can move, or remove it, as needed.
            this.kasa1TableAdapter.Fill(this.girisDataSet.kasa1);
            // TODO: This line of code loads data into the 'girisDataSet.durum' table. You can move, or remove it, as needed.
            this.durumTableAdapter.Fill(this.girisDataSet.durum);
            // TODO: This line of code loads data into the 'girisDataSet.ecz_sipar' table. You can move, or remove it, as needed.
            this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);
            this.eczaneTableAdapter.Fill(this.girisDataSet.eczane);
            this.ilacTableAdapter.Fill(this.girisDataSet.ilac);
            // TODO: This line of code loads data into the 'girisDataSet.eczane' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'girisDataSet.eczane_sip' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'girisDataSet.ilac' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'girisDataSet.eczane' table. You can move, or remove it, as needed.


            timer1.Interval = 10000;
            timer1.Start();
            ilal.Hide();
            ilsat.Hide();
            Bilgi.Hide();
            eczsilgb.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Hide();
            ilacbil.Hide();
            ilsatdurumu.Hide();
            kasadurum.Hide();


        }


     

        public void ilaçSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilal.Hide();
            ilsat.Show();
            Bilgi.Show();
            eczsilgb.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Hide();
            ilacbil.Hide();
            ilsatdurumu.Hide();
            kasadurum.Hide();

        }

        private void ilaçAlışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilal.Show();
            
            ilsat.Hide();
            Bilgi.Show();
            eczsilgb.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Hide();
            ilacbil.Hide();
            ilsatdurumu.Hide();
            kasadurum.Hide();
        }
        String a, b;
        int price = 1;
        int pricecash = 1;
        int marj = 1;
        int end = 1;
        int end2 = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select  adet_ucret,marj from ilac where ilac_adi='" + ilacadisat.Text + "'", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               a  = dr["adet_ucret"].ToString();
                b = dr["marj"].ToString();

            }
            baglanti.Close();
            price = Convert.ToInt32(adet.Text);
            pricecash = Convert.ToInt32(a);
            marj = Convert.ToInt32(b);
            baglanti.Open();
            komut.Connection = baglanti;
            


            /* komut = new OleDbCommand("insert into eczane(eczane_adi,kul_ad,sif) values ('burak','burak','burak')");*/
            try
            {
                
                
                komut.CommandText = "UPDATE ilac SET adet=adet-"+adet.Text+ " Where ilac_adi='" + ilacadisat.Text + "'";
                komut.ExecuteScalar();




                komut.CommandText= "insert into durum (eczane_adi,ilac_adi,adet,adet_ucret,kar_marj) values ('" + comboBox1.Text + "','" + ilacadisat.Text + "','" + adet.Text + "','" + a + "','" + b + "')";
                komut.ExecuteScalar();
                end = pricecash * price;
                komut.CommandText = "UPDATE kasa SET satilan_urun_degeri=satilan_urun_degeri+" + end + " where sira=1";
                komut.ExecuteScalar();
                end2 = price * marj;
                komut.CommandText = "UPDATE kasa SET satilan_kar=satilan_kar+" + end2 + " where sira=1";
                komut.ExecuteScalar();
                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("lutfen sayi giriniz");

            }
            baglanti.Close();
           
          



        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;




            /* komut = new OleDbCommand("insert into eczane(eczane_adi,kul_ad,sif) values ('burak','burak','burak')");*/


            komut.CommandText = "insert into eczane (eczane_adi,kul_ad,sif) values ('" + eczeklead.Text + "','" + kulad.Text + "','" + sif.Text + "')";



            komut.ExecuteScalar();
            /* komut.CommandText = "CREATE TABLE eczane_sip ";



             komut.ExecuteScalar();*/

            baglanti.Close();
     

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from eczane where eczane_adi='" + eczsilcb.Text + "'";

            komut.ExecuteScalar();
            baglanti.Close();
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void eczaneDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilal.Hide();
            ilsat.Hide();
            Bilgi.Hide();

            eczsilgb.Hide();
            ilacbil.Hide();
            ecz_ekle.Hide();
            eczduzenle.Show();
            eczkulgenel.Show();
            ilsatdurumu.Hide();
            kasadurum.Hide();
        }


      

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*dıger boxları otomatık doldurma*/
            baglanti.Open();
            komut = new OleDbCommand("Select  kul_ad,sif from eczane where eczane_adi='" +eczduzadi.Text+ "'", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kulduz.Text = dr["kul_ad"].ToString();
                sifduz.Text = dr["sif"].ToString();

            }
            baglanti.Close();
         

        }
        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE eczane SET kul_ad='"+kulduz.Text+"' WHERE eczane_adi='"+eczduzadi.Text+"'";
            komut.ExecuteScalar();
            komut.CommandText = "UPDATE eczane SET sif='" +sifduz.Text+"' WHERE eczane_adi='" + eczduzadi.Text + "'";
            komut.ExecuteScalar();
            baglanti.Close();
       
        }

        private void sifduz_TextChanged(object sender, EventArgs e)
        {

        }

        private void ecz_ekle_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (siparischeck.Checked == false)
            {
                siparisdurumu();

            }
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goster_Click(object sender, EventArgs e)
        {
            ilacbil.Show();
            ilal.Hide();
            ilsat.Show();
            Bilgi.Hide();
            eczsilgb.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Hide();
            ilsatdurumu.Hide();
            kasadurum.Hide();

            /* siparis();*/

        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(sipcbb.Text);
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from ecz_sipar where siparis_no="+a+"";

            komut.ExecuteScalar();
            baglanti.Close();
            this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);

        }

        private void aktarma_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(sipcbb.Text);
          
            baglanti.Open();
            komut = new OleDbCommand("Select eczane_adi,ilac_adi,adet from ecz_sipar where siparis_no="+a+"", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ilacadisat.Text = dr["ilac_adi"].ToString();
                adet.Text = dr["adet"].ToString();
                comboBox1.Text = dr["eczane_adi"].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from ecz_sipar where siparis_no=" + a + "";

            komut.ExecuteScalar();

            baglanti.Close();
            this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);
            
        }
        string deger;
        int gelisucret = 1;
        int adet_sayi = 1;
        int gelen = 1;

        private void karZararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kasadurum.Show();
            ilal.Hide();
            ilsat.Hide();
            Bilgi.Hide();
            eczsilgb.Hide();
            ecz_ekle.Hide();
            eczduzenle.Hide();
            eczkulgenel.Hide();
            ilacbil.Hide();
            ilsatdurumu.Hide();
           
        }

        private void ilacal_Click(object sender, EventArgs e)
        {
           

            baglanti.Open();
            komut = new OleDbCommand("Select adet_gelucret from ilac where ilac_adi='"+ılalcb.Text+"'", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                deger = dr["adet_gelucret"].ToString();
                

            }
            baglanti.Close();
            int gelisucret = Convert.ToInt32(deger);


            baglanti.Open();
            komut.Connection = baglanti;




            /* komut = new OleDbCommand("insert into eczane(eczane_adi,kul_ad,sif) values ('burak','burak','burak')");*/
            try
            {


                komut.CommandText = "UPDATE ilac SET adet=adet+" + ilaladet.Text + " Where ilac_adi='" + ılalcb.Text+ "'";



                komut.ExecuteScalar();
                adet_sayi=  Convert.ToInt32(ilaladet.Text);
                gelen = adet_sayi * gelisucret;
                
                komut.CommandText = "UPDATE kasa SET urun_deger_top=urun_deger_top+"+gelen+" where sira=1";



                komut.ExecuteScalar();


                baglanti.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("lutfen pozitif sayi giriniz");

            }
            baglanti.Close();
            this.ecz_siparTableAdapter.Fill(this.girisDataSet.ecz_sipar);
            this.eczaneTableAdapter.Fill(this.girisDataSet.eczane);
            this.ilacTableAdapter.Fill(this.girisDataSet.ilac);
        }
    }
}
