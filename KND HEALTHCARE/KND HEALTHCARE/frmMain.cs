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
using KND_HEALTHCARE.Report;
using KND_HEALTHCARE.Staff;

namespace KND_HEALTHCARE
{
    public partial class frmMain : Form
    {
        Model1 db = new Model1();
        frmDN login;
        string idLogin = frmDN.idlogin;
        private Form IsActive(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmQLLoaiThuoc));
            if (form == null)
            {
                frmQLLoaiThuoc f = new frmQLLoaiThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate(); ;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmQLThuoc));
            if (form == null)
            {
                frmQLThuoc f = new frmQLThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate(); ;
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(QLNV));
            if (form == null)
            {
                QLNV f = new QLNV();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmTimKiem));
            if (form == null)
            {
                frmTimKiem f = new frmTimKiem();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmNCC));
            if (form == null)
            {
                frmNCC f = new frmNCC();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(p => p.MANV == frmDN.idlogin);
            lblTenNV.Text = nv.TENNV;
            
            if(nv.CHUCVU.Equals("Quản Lí") == true)
            {
                rbpageManagement.Visible = true;
            }
            else
            {
                rbpageManagement.Visible = false;
            }
        }

        private void barbtnBanThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmBanThuoc));
            if (form == null)
            {
                frmBanThuoc f = new frmBanThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmThongTinThuoc));
            if (form == null)
            {
                frmThongTinThuoc f = new frmThongTinThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btnTaiKhoanCuaToi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmMyUser));
            if (form == null)
            {
                frmMyUser f = new frmMyUser();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmHuyThuoc));
            if (form == null)
            {
                frmHuyThuoc f = new frmHuyThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void barbtnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\notepad.exe");
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(rptNhanVien));
            if (form == null)
            {
                rptNhanVien f = new rptNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(rptThuoc));
            if (form == null)
            {
                rptThuoc f = new rptThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(rptNCC));
            if (form == null)
            {
                rptNCC f = new rptNCC();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(rptHD));
            if (form == null)
            {
                rptHD f = new rptHD();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void btnHuyThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(rptThuocHuy));
            if (form == null)
            {
                rptThuocHuy f = new rptThuocHuy();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmQLKH));
            if (form == null)
            {
                frmQLKH f = new frmQLKH();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = IsActive(typeof(frmNhapThuoc));
            if (form == null)
            {
                frmNhapThuoc f = new frmNhapThuoc();
                f.MdiParent = this;
                f.Show();
            }
            else
                form.Activate();
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptPhieuMua frmHDN = new rptPhieuMua();
            frmHDN.Show();
        }

        private void barButtonItem10_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptContact contact = new rptContact();
            contact.Show();
        }
    }
}
