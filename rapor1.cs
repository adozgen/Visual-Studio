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
    public partial class rapor1 : Form
    {
        public rapor1()
        {
            InitializeComponent();
        }

        private void rapor1_Load(object sender, EventArgs e)
        {

           
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
            
            
        }
       
    }
}
