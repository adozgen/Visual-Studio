
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
    public partial class kayıtlistesi : Form
    {
       
        public mainform mfrm;
        public kayitekle kytekle;

        public kayıtlistesi()
        {
            InitializeComponent();

        }


                  



        private void kayıtlistesi_Load(object sender, EventArgs e)
        {
            displayrecords();
        }
        public void displayrecords()
        {

            baglanti bgln = new baglanti();
            bgln.baglan();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kayitbilgileri", bgln.baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

        }

        private void kayıtSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            baglanti bgln = new baglanti();
            bgln.baglan();

            DataTable dt = new DataTable();
            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "silmek istediğinize eminmisiniz?", "kayıt sil", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                SqlDataAdapter da = new SqlDataAdapter("delete from kayitbilgileri where ID =" + dataGridView1.CurrentRow.Cells[0].Value + "", bgln.baglan());
                da.Fill(dt);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dt);
                displayrecords();
                bgln.baglan().Close();
            }
        }

        private void kayıtGüncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kayitekle kytekle = new kayitekle();
            kytekle.Show();
            baglanti bgln = new baglanti();
            bgln.baglan();
            SqlCommand cmd = new SqlCommand("select ilçeadı from ilçeler", bgln.baglan());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                kytekle.cbilçe.Items.Add(rd[0].ToString()); //rd[0] İLCEAD
            }
            bgln.baglan().Close();
            kytekle.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kytekle.dtpzaman.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kytekle.txtadsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kytekle.cbkurum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kytekle.txttel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kytekle.txtsonuc.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            kytekle.txtsikayet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kytekle.cbmah.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            kytekle.txtinceleme.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            kytekle.txtilgili.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            kytekle.cbilçe.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            kytekle.txtic.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            kytekle.txtdis.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            kytekle.txtcadde.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            kytekle.txtaciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            kytekle.txtapt.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            

            

        }

        private void kayıtEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kayitekle kytekle = new kayitekle();
            kytekle.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            servisler servis = new servisler();
            rapor1 raporum = new rapor1();

            List<servisler.kayıtlar> liste = new List<servisler.kayıtlar>();
            
         

            int kyttoplam;
            kyttoplam = dataGridView1.Rows.Count;
        
            for (int i =0; i < kyttoplam -1 ; i++)
            
            {

                servisler.kayıtlar item = new servisler.kayıtlar();
                item.ID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                item.TARİH = dataGridView1.Rows[i].Cells[1].Value.ToString();
                item.ADSOYAD = dataGridView1.Rows[i].Cells[2].Value.ToString();
                item.KURUM = dataGridView1.Rows[i].Cells[3].Value.ToString();
                item.TELEFON = dataGridView1.Rows[i].Cells[4].Value.ToString();
                item.SİKAYET = dataGridView1.Rows[i].Cells[5].Value.ToString();
                item.İLGİLİBİRİM = dataGridView1.Rows[i].Cells[6].Value.ToString();
                item.AÇIKLAMA = dataGridView1.Rows[i].Cells[7].Value.ToString();
                item.İLÇE = dataGridView1.Rows[i].Cells[8].Value.ToString();
                item.MAHALLE = dataGridView1.Rows[i].Cells[9].Value.ToString();
                item.CADDE = dataGridView1.Rows[i].Cells[10].Value.ToString();
                item.APARTMAN = dataGridView1.Rows[i].Cells[11].Value.ToString();
                item.DIŞKAPI = dataGridView1.Rows[i].Cells[12].Value.ToString();
                item.İÇKAPI = dataGridView1.Rows[i].Cells[13].Value.ToString();
                item.İNCELEME = dataGridView1.Rows[i].Cells[14].Value.ToString();
                item.SONUC = dataGridView1.Rows[i].Cells[15].Value.ToString();

                liste.Add(item);

                
            }

            raporum.kayıtlarBindingSource.DataSource = liste.ToArray();
            raporum.reportViewer1.RefreshReport();
            raporum.Show();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        


        private void button3_Click(object sender, EventArgs e)
        {

            

            servisler servis = new servisler();
            rapor3 raporum = new rapor3();

            List<servisler.kayıtlar> liste = new List<servisler.kayıtlar>();
            int kyttoplam;
            kyttoplam = dataGridView1.Rows.Count;

            for (int i = 0; i < kyttoplam - 1; i++)
            {

                servisler.kayıtlar item = new servisler.kayıtlar();
                item.TARİH = dataGridView1.Rows[i].Cells[1].Value.ToString();
                item.ADSOYAD = dataGridView1.Rows[i].Cells[2].Value.ToString();
                item.İLÇE = dataGridView1.Rows[i].Cells[8].Value.ToString();
                item.MAHALLE = dataGridView1.Rows[i].Cells[9].Value.ToString();
                item.SİKAYET = dataGridView1.Rows[i].Cells[5].Value.ToString();
                item.İLGİLİBİRİM = dataGridView1.Rows[i].Cells[6].Value.ToString();
                item.SONUC = dataGridView1.Rows[i].Cells[15].Value.ToString();

                liste.Add(item);
            }
            raporum.kayıtlarBindingSource.DataSource = liste.ToArray();
            raporum.reportViewer1.RefreshReport();
            raporum.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayrecords();
        }

        private void kayıtlistesi_Load_1(object sender, EventArgs e)
        {

        }
    }
}