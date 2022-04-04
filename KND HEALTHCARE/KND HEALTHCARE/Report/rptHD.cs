using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KND_HEALTHCARE.Report
{
    public partial class rptHD : Form
    {
        public rptHD()
        {
            InitializeComponent();
        }

        private void rptHD_Load(object sender, EventArgs e)
        {
            crpHD rpt = new crpHD();
            crvHDs.ReportSource = rpt;
        }

        private void crvHDs_Load(object sender, EventArgs e)
        {

        }
    }
}
