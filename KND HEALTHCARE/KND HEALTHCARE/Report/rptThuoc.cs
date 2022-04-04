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
    public partial class rptThuoc : Form
    {
        public rptThuoc()
        {
            InitializeComponent();
        }

        private void rptThuoc_Load(object sender, EventArgs e)
        {
            crpThuoc rpt = new crpThuoc();
            crvThuocs.ReportSource = rpt;
        }
    }
}
