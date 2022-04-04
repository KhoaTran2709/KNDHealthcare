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
    public partial class rptThuocHuy : Form
    {
        public rptThuocHuy()
        {
            InitializeComponent();
        }

        private void rptThuocHuy_Load(object sender, EventArgs e)
        {
            crpThuocHuy rpt = new crpThuocHuy();
            crvThuocHuys.ReportSource = rpt;
        }
    }
}
