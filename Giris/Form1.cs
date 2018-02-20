using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void Eczane_Click(object sender, EventArgs e)
        {
            
            Eczanecs cs = new Eczanecs();

            cs.Visible = true;
            this.Visible = false;

        }

        private void extmain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

            String a = DateTime.Now.ToShortDateString();
            String b = DateTime.Now.ToShortTimeString();
            timer1.Enabled=true; 
            kayy.Text = ("Hosgeldiniz... Tarih  : "+a+"  "+b+"    " );
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kayy.Text = kayy.Text.Substring(1) + kayy.Text.Substring(0, 1);
           

        }


        public void kapa() {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Close();
            EczaDeposu1 err = new EczaDeposu1();
            err.Show();
            this.Hide();
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Close();
            EczaDeposu1 err = new EczaDeposu1();
            err.Show();
            this.Hide();
        }
    }
}
