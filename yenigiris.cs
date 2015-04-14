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
    public partial class yenigiris : Form
    {
        public yenigiris()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti bgln = new baglanti();
            bgln.baglan();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ornek", bgln.baglan());
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[1] = txtkad.Text;
            r[2] = txtsifre.Text;
            dt.Rows.Add(r);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            bgln.baglan().Close();
            this.Close();
        }
    }
}
