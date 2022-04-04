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
namespace KND_HEALTHCARE
{
    public partial class frmTimKiem : Form
    {
        Model1 db = new Model1();
        Database dba = new Database();

        public frmTimKiem()
        {
            InitializeComponent();
        }
        private void BindGrid(List<NHANVIEN> listNV)
        {
            dgvTKnv.Rows.Clear();
            foreach (var item in listNV)
            {
                int index = dgvTKnv.Rows.Add();
                dgvTKnv.Rows[index].Cells[0].Value = item.MANV;
                dgvTKnv.Rows[index].Cells[1].Value = item.TENNV;

                DateTime t = (DateTime)item.NGAYSINH;
                String dateInString = t.ToString("dd/MM/yyyy");
                dgvTKnv.Rows[index].Cells[2].Value = dateInString;

                dgvTKnv.Rows[index].Cells[3].Value = item.GIOITINH;
                dgvTKnv.Rows[index].Cells[4].Value = item.SDTNV;
                dgvTKnv.Rows[index].Cells[5].Value = item.CHUCVU;
            }
        }
        private void BindGrid(List<THUOC> listThuoc)
        {
            dgvTKT.Rows.Clear();
            foreach (var item in listThuoc)
            {
                int index = dgvTKT.Rows.Add();
                dgvTKT.Rows[index].Cells[0].Value = item.MATHUOC;
                dgvTKT.Rows[index].Cells[1].Value = item.TENTHUOC;
                dgvTKT.Rows[index].Cells[2].Value = item.DVT;
                dgvTKT.Rows[index].Cells[3].Value = item.DONGIA;
                dgvTKT.Rows[index].Cells[4].Value = item.SOLUONGTON;
                DateTime tNSX = (DateTime)item.NGAYSANXUAT;
                String dateInStringNSX = tNSX.ToString("dd/MM/yyyy");
                dgvTKT.Rows[index].Cells[5].Value = dateInStringNSX;
                DateTime tHSD = (DateTime)item.HANSUDUNG;
                String dateInStringHSD = tHSD.ToString("dd/MM/yyyy");
                dgvTKT.Rows[index].Cells[6].Value = dateInStringHSD;
                dgvTKT.Rows[index].Cells[7].Value = item.MOTA;
                dgvTKT.Rows[index].Cells[8].Value = item.HINHTHUOC;
                dgvTKT.Rows[index].Cells[9].Value = item.LOAITHUOC.TENLOAITHUOC;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cboFindLoaiThuoc.Text.Length == 0)
            {
                MessageBox.Show("Chọn loại thuốc cần tìm!", "Thông Báo!");
                return;
            }
            List<THUOC> th = db.THUOCs.Where(p => p.LOAITHUOC.TENLOAITHUOC == cboFindLoaiThuoc.Text).ToList();
            BindGrid(th);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtTKtt.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên thuốc cần tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dba = new Database();
                DataTable dt = dba.Execute("Select * from THUOC where TENTHUOC like N'%" + txtTKtt.Text + "%'");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Tên thuốc không tồn tại!", "Thông Báo!");
                List<THUOC> th = db.THUOCs.Where(p => p.TENTHUOC.Contains(txtTKtt.Text) == true).ToList();
                BindGrid(th);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            if (txtIDnv.Text.Length != 10)
            {
                MessageBox.Show("Nhập đủ 10 ký tự!", "Thông Báo!");
                return;
            }
            else
            {
                dba = new Database();
                DataTable dt = dba.Execute("Select * from NHANVIEN where MANV = N'" + txtIDnv.Text + " ' ");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Mã nhân viên không tồn tại!", "Thông Báo!");
                List<NHANVIEN> nv = db.NHANVIENs.Where(p => p.MANV.Contains(txtIDnv.Text) == true).ToList();
                BindGrid(nv);
            }
        }

        private void btnFindTen_Click(object sender, EventArgs e)
        {
            if (txtHTnv.Text.Length == 0)
            {
                MessageBox.Show("Nhập tên NV cần tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dba = new Database();
                DataTable dt = dba.Execute("Select * from NHANVIEN where TENNV like N'%" + txtHTnv.Text + "%'");
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Tên nhân viên không tồn tại!", "Thông Báo!");
                List<NHANVIEN> nv = db.NHANVIENs.Where(p => p.TENNV.Contains(txtHTnv.Text) == true).ToList();
                BindGrid(nv);
            }
        }

        private void cboFindLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            String sql = "Select * From LOAITHUOC";
            cboFindLoaiThuoc.DataSource = Database.Singleton.Execute(sql);
            cboFindLoaiThuoc.ValueMember = "MALOAITHUOC";
            cboFindLoaiThuoc.DisplayMember = "TENLOAITHUOC";
        }
    }
}
