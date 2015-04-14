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
    public partial class sifredegistir : Form
    {
        
        public sifredegistir()
        {
            InitializeComponent();
         
        }

        private void btnsfrdegistr_Click(object sender, EventArgs e)
        {

            baglanti bgln = new baglanti();
            bgln.baglan();

            SqlCommand cm = new SqlCommand();
            cm.Connection = bgln.baglan();
            cm.CommandText="Update ornek SET SİFRE= '" + txtdegissifre.Text + "'Where ID='" +txtID.Text+"'";
            cm.ExecuteNonQuery();
            bgln.baglan().Close();
            MessageBox.Show("Şifreniz başarıyla değiştirildi!");
            this.Close();
        }
    }
}
