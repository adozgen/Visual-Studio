using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class kayıtform : Form
    {
        public kayıtform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            servisler servis = new servisler();
            rapor2 rapor = new rapor2();

            List<servisler.kayıtlar> liste = new List<servisler.kayıtlar>();

            servisler.kayıtlar item = new servisler.kayıtlar();
            item.ADSOYAD = txtkad.Text;
            item.KURUM = cbkkurum.Text;
            item.TELEFON = txtktel.Text;
            item.SİKAYET = txtksikayet.Text;
            item.SONUC = txtkinceleme.Text;
            liste.Add(item);


            rapor.kayıtlarBindingSource.DataSource = liste.ToArray();
            rapor.reportViewer1.RefreshReport();
            rapor.Show();

        }

        private void kayıtform_Load(object sender, EventArgs e)
        {

        }
    }

}

