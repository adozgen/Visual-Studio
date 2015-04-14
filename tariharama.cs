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
    public partial class tariharama : Form
    {
        public tariharama()
        {
            InitializeComponent();
        }

        private void tariharama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıtlistesi kytlistesi = new kayıtlistesi();
            kytlistesi.Show();

            baglanti bgln = new baglanti();
            bgln.baglan();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM kayitbilgileri WHERE TARİH BETWEEN '" + dateTimePicker1.Value.ToString() + "' AND '" + dateTimePicker2.Value.ToString() + "'", bgln.baglan());
            da.Fill(dt);
            kytlistesi.dataGridView1.DataSource = dt;
        }
    }
}
