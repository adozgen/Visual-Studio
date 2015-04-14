using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    
    public partial class giris : Form
    {

    
        public giris()
        {
            InitializeComponent();
          
        }

        


        private void giris_Load(object sender, EventArgs e)
        {
            AcceptButton = btngiris;
            
        }




        private void btngiris_Click(object sender, EventArgs e)
        {

            baglanti bgln = new baglanti();
            bgln.baglan();
            SqlCommand cm = new SqlCommand("SELECT ID FROM ornek WHERE AD='" + txtkad.Text + "' and SİFRE='" + txtsifre.Text + "'", bgln.baglan());
            
            
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                txtkad.Clear();
                txtsifre.Clear();
                mainform mfrm = new mainform();
                mfrm.lblKullaniciID.Text = dr[0].ToString();
                mfrm.Show();
                
                
            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız!");
            }
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            yenigiris yngris = new yenigiris();
            yngris.Show();
        }
    }
}
