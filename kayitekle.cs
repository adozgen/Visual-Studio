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
   
    public partial class kayitekle : Form
    {
        
        public kayıtform kytfrm;
        public mainform mfrm;
        public kayıtlistesi kytliste;
       
        

        public kayitekle()
        {
            InitializeComponent();
            kytliste = new kayıtlistesi();
            kytliste.kytekle = this;
        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {

            addrecords();

            
            

        }
        private void addrecords()
        {

            baglanti bgln = new baglanti();
            bgln.baglan();


                if (txtadsoyad.Text.Trim() == "" || cbkurum.Text.Trim() == "" || txttel.Text.Trim() == "" || txtsikayet.Text == "")
                {
                    MessageBox.Show("Gerekli alanı doldurmadınız!");
                }
                else
                {
                    DialogResult dugmesec;
                    dugmesec = MessageBox.Show(this, "Kaydetmek istediğinize eminmisiniz?", "Kayıt Ekle", MessageBoxButtons.YesNo);
                    if (dugmesec == DialogResult.Yes)
                    {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kayitbilgileri", bgln.baglan());
                    da.Fill(dt);
                    DataRow r = dt.NewRow();
                    r[1] = dtpzaman.Value.ToString();
                    r[2] = txtadsoyad.Text;
                    r[3] = cbkurum.Text;
                    r[4] = txttel.Text;
                    r[5] = txtsikayet.Text;
                    r[6] = txtilgili.Text;
                    r[7] = txtaciklama.Text;
                    r[8] = cbilçe.Text;
                    r[9] = cbmah.Text;
                    r[10] = txtcadde.Text;
                    r[11] = txtapt.Text;
                    r[12] = txtdis.Text;
                    r[13] = txtic.Text;
                    r[14] = txtinceleme.Text;
                    r[15] = txtsonuc.Text;
                    dt.Rows.Add(r);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(dt);
                    bgln.baglan().Close();
                    this.Close();
                    }
                
                }

            }
        

        private void btnguncelle_Click(object sender, EventArgs e)
        {


            baglanti bgln = new baglanti();
            bgln.baglan();
            kayıtlistesi kytliste = new kayıtlistesi();
            kytliste.Show();

            SqlCommand kmt = new SqlCommand();
            kmt.Connection = bgln.baglan();

            kmt.CommandText ="Update kayitbilgileri SET ADSOYAD='" + txtadsoyad.Text + "', KURUM= '" + cbkurum.Text + "',TELEFON='" + txttel.Text + "',SIKAYET ='" + txtsikayet.Text + "',ILGILIBIRIM='" + txtilgili.Text + "',ACIKLAMA='" + txtaciklama.Text + "',ILCE='" + cbilçe.Text + "',MAHALLE='" + cbmah.Text + "',CADDE='" + txtcadde.Text + "',APARTMAN='" + txtapt.Text + "',DISKAPI='" + txtdis.Text + "',ICKAPI='" + txtic.Text + "',INCELEME='" + txtinceleme.Text + "',SONUC='" + txtsonuc.Text + "',TARİH='"+dtpzaman.Value+ "'Where ID='" +
                                 textBox1.Text + "'";
            kmt.ExecuteNonQuery();
            kytliste.displayrecords();
            bgln.baglan().Close();
            
            
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar!= (char)08)
            {
                e.Handled = true;
            }
            
            
                
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            kayıtform kytfrm = new kayıtform();
            kytfrm.Show();
            kytfrm.txtkad.Text = txtadsoyad.Text;
            kytfrm.txtktel.Text = txttel.Text;
     
            kytfrm.cbkkurum.Text = cbkurum.Text;
            kytfrm.txtksikayet.Text = txtsikayet.Text;
            kytfrm.txtkinceleme.Text = txtinceleme.Text;
        }

        private void cbilçe_SelectedIndexChanged(object sender, EventArgs e)
        {


            baglanti bgln = new baglanti();
            bgln.baglan();
            SqlCommand cmd = new SqlCommand("select ilçeid from ilçeler where ilçeadı='" + cbilçe.Text + "'",bgln.baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                
                label16.Text = dr[0].ToString();
            }
            bgln.baglan().Close();
         
                        

        }

        private void cbmah_MouseUp(object sender, MouseEventArgs e)
        {

            baglanti bgln = new baglanti();
            bgln.baglan();
            SqlCommand cm = new SqlCommand("select mahadı from mahalle where ilçeid='" + label16.Text + "'", bgln.baglan());
            SqlDataReader d = cm.ExecuteReader();
            cbmah.Items.Clear();
            while (d.Read())
            {

                cbmah.Items.Add(d[0].ToString());


            }
            bgln.baglan().Close();
                 
        }

        private void cbmah_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kayitekle_Load(object sender, EventArgs e)
        {

        }


    







 
    }
}
