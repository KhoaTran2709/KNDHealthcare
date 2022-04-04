using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KND_HEALTHCARE.Models;
using Microsoft.Reporting.WinForms;

namespace KND_HEALTHCARE.Report
{
    
    public partial class rptPhieuMua : Form
    {
        public class HoaDonPMT
        {
            int hdspm;
            DateTime nm;
            string sdtkh;
            string tt;
            int slm;
            int dg;
            decimal tien;

            public int Hdspm { get => hdspm; set => hdspm = value; }
            public DateTime Nm { get => nm; set => nm = value; }
            public string Sdtkh { get => sdtkh; set => sdtkh = value; }
            public string Tt { get => tt; set => tt = value; }
            public int Slm { get => slm; set => slm = value; }
            public int Dg { get => dg; set => dg = value; }
            public decimal Tien { get => tien; set => tien = value; }
        }
        Database db;
        
        public rptPhieuMua()
        {
            InitializeComponent();
        }

        private void rptPhieuMua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsHDPMT.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dtsHDPMT.DataTable1);
            // TODO: This line of code loads data into the 'dtsHDPMT.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.Fill(this.dtsHDPMT.DataTable1);


            //try
            //{

            //    db = new Database();
            //    DataTable dt = db.Execute("select  ctpmt.SOPHIEUMUA,pmt.NGAYMUA, pmt.SDTKHACHHANG, thuoc.TENTHUOC, ctpmt.SOLUONGMUA,ctpmt.DONGIATHUOC ,pmt.TONGTIEN from PHIEUMUATHUOC pmt, CHITIETPHIEUMUATHUOC ctpmt, THUOC thuoc where pmt.SOPHIEUMUA = ctpmt.SOPHIEUMUA AND ctpmt.MATHUOC = thuoc.MATHUOC order by pmt.SOPHIEUMUA");
            //    DataTable dt = db.Execute("select pmt.SOPHIEUMUA,pmt.NGAYMUA, pmt.SDTKHACHHANG, thuoc.TENTHUOC, ctpmt.SOLUONGMUA,thuoc.DONGIA ,pmt.TONGTIEN from PHIEUMUATHUOC pmt, CHITIETPHIEUMUATHUOC ctpmt, THUOC thuoc where pmt.SOPHIEUMUA = ctpmt.SOPHIEUMUA AND ctpmt.MATHUOC = thuoc.MATHUOC and pmt.SOPHIEUMUA = (select max(pmt.SOPHIEUMUA) from CHITIETPHIEUMUATHUOC pmt)");

            //    List<HoaDonPMT> hdpmt = new List<HoaDonPMT>();
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        HoaDonPMT hoadon = new HoaDonPMT();
            //        hoadon.Hdspm = Int32.Parse(dt.Rows[i][0].ToString());

            //        hoadon.Nm = DateTime.Parse(dt.Rows[i][1].ToString());
            //        hoadon.Sdtkh = dt.Rows[i][2].ToString();
            //        hoadon.Tt = dt.Rows[i][3].ToString();
            //        hoadon.Slm = Int32.Parse(dt.Rows[i][4].ToString());
            //        hoadon.Dg = Int32.Parse(dt.Rows[i][5].ToString());
            //        hoadon.Tien = Decimal.Parse(dt.Rows[i][6].ToString());
            //        hdpmt.Add(hoadon);
            //    }
            //    var reportDataSource = new ReportDataSource("DataSet1", hdpmt);
            //    this.reportViewer1.LocalReport.DataSources.Clear();
            //    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //    this.reportViewer1.RefreshReport();
            //    this.reportViewer1.RefreshReport();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void cTHDPMTBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dtsHDPMT1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dtsHDPMTBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
