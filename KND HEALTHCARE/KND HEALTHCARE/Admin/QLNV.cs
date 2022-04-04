using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using KND_HEALTHCARE.Models;
namespace KND_HEALTHCARE
{
    public partial class QLNV : DevExpress.XtraEditors.XtraForm
    {
        Model1 db = new Model1();
        List<NHANVIEN> listNV;
        NHANVIEN nv;
        public QLNV()
        {
            InitializeComponent();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kNDHEALTHCAREDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter1.Fill(this.kNDHEALTHCAREDataSet1.NHANVIEN);
            // TODO: This line of code loads data into the 'kNDHEALTHCAREDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.kNDHEALTHCAREDataSet.NHANVIEN);
            string image = "D:/Learn/[DA] DoAnChuyenNganh/Nhu/KND HEALTHCARE/Picture/received_753638414799148.jpeg";
            //tileView1.ColumnSet. .Images = new ImageLocation().ToString();


        }

        private void MenuQLNV_Opening(object sender, CancelEventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLNV qlnv = new frmQLNV();
            qlnv.Show();
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
            //grdQLNV.RefreshDataSource();
            //grdQLNV.Show();
        }

        private void nHANVIENBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}