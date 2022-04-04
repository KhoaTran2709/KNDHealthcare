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
    public partial class rptNhanVien : Form
    {
        public rptNhanVien()
        {
            InitializeComponent();
        }

        private void rptNhanVien_Load(object sender, EventArgs e)
        {
            crpNhanVien rpt = new crpNhanVien();
            crvNhanViens.ReportSource = rpt;
        }
    }
}
