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
    public partial class adkurumarama : Form
    {
        public adkurumarama()
        {
            InitializeComponent();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            kayıtlistesi kytliste=new kayıtlistesi();
            kytliste.Show();

            baglanti bgln = new baglanti();
            bgln.baglan();
            if (checkkurum.Checked == true && checkad.Checked == true)
            {

                DataTable dt = new DataTable();
                if (cbkurum.Text.Trim() == "" && txtad.Text.Trim() == "")
                {
                    
                    SqlDataAdapter da = new SqlDataAdapter("select * from kayitbilgileri", bgln.baglan());
                    da.Fill(dt);
                    kytliste.dataGridView1.DataSource = dt;
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from kayitbilgileri where ADSOYAD LIKE '%" + txtad.Text + "%' AND KURUM='" + cbkurum.Text + "'", bgln.baglan());
                    da.Fill(dt);
                    kytliste.dataGridView1.DataSource = dt;
                }




            }
            else if (checkad.Checked == true)
            {
                DataTable dt = new DataTable();
                if (txtad.Text.Trim() == "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from kayitbilgileri", bgln.baglan());
                    da.Fill(dt);
                    kytliste.dataGridView1.DataSource = dt;
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from kayitbilgileri where ADSOYAD LIKE '%" + txtad.Text + "%'", bgln.baglan());
                    da.Fill(dt);
                    kytliste.dataGridView1.DataSource = dt;
                }

            }
            else if (checkkurum.Checked == true)
            {
                DataTable dt = new DataTable();
                if (cbkurum.Text.Trim() == "")
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from kayitbilgileri", bgln.baglan());
                    da.Fill(dt);
                    kytliste.dataGridView1.DataSource = dt;
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from kayitbilgileri where KURUM LIKE '%" + cbkurum.Text + "%'", bgln.baglan());
                    da.Fill(dt);
                    kytliste.dataGridView1.DataSource = dt;
                }
            }
        }

        private void checkad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkad.Checked)
            {
                txtad.Enabled = true;

            }
            else
            {
                txtad.Enabled = false;
            }
        }

        private void checkkurum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkkurum.Checked)
            {
                cbkurum.Enabled = true;

            }
            else
            {
               cbkurum.Enabled = false;
            }
        }
    }
}
