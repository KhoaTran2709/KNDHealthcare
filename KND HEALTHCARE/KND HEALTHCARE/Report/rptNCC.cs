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
    public partial class rptNCC : Form
    {
        public rptNCC()
        {
            InitializeComponent();
        }

        private void rptNCC_Load(object sender, EventArgs e)
        {
            crpNCC rpt = new crpNCC();
            crvNCCs.ReportSource = rpt;
        }
    }
}
