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
    public partial class mainform : Form
    {
        public kayıtlistesi kytliste;
        public kayitekle kytekle;
        public giris grs;
        public sifredegistir sfrdgstr;
        public mainform()
        {
            InitializeComponent();
            kytekle = new kayitekle();
            kytliste = new kayıtlistesi();
            grs = new giris();
            sfrdgstr = new sifredegistir();
            
            kytliste.mfrm = this;
            kytekle.mfrm = this;
            
        }

        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitekle frmKayit = new kayitekle(); //mainformdan Kayıt ekleyi cagırdık
            frmKayit.MdiParent = this; 
            frmKayit.Show();
            baglanti bgln = new baglanti();
            bgln.baglan();

            SqlCommand cmd = new SqlCommand("select ilçeadı from ilçeler",bgln.baglan());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                frmKayit.cbilçe.Items.Add(rd[0].ToString()); //rd[0] İLCEAD
            }
           bgln.baglan().Close();
        }

        private void kayıtListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıtlistesi kayitliste = new kayıtlistesi();
            kayitliste.MdiParent = this;
            kayitliste.Show();
        }



        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void kayıtAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            kayıtlistesi kytliste = new kayıtlistesi();
            kytliste.Show();
            kytliste.dataGridView1.DataSource = null;

            
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenigiris yngrs = new yenigiris();
            yngrs.Show();

        }

        private void kayıtListesiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kayıtlistesi kytliste = new kayıtlistesi();
            kytliste.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifredegistir sfrdgstr = new sifredegistir();
            sfrdgstr.Show();
            baglanti bgln = new baglanti();
            bgln.baglan();


            
            SqlCommand sorgu = new SqlCommand();
            sorgu.Connection =bgln.baglan();
            giris grs=new giris();
            sorgu.CommandText = "SELECT AD from ornek where ID='" +lblKullaniciID  + "'";
            sfrdgstr.txtID.Text = lblKullaniciID.Text;

        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapor1 rpr1 = new rapor1();
            rpr1.Show();
        }

        private void adVeKurumaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adkurumarama adkurum = new adkurumarama();
            adkurum.Show();
        }

        private void tariheGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tariharama trharama = new tariharama();
            trharama.Show();
        }

  
    }
}
