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
    public partial class frmHuyThuoc : Form
    {
        Database dba = new Database();
        Model1 db = new Model1();
        List<CHITIETBIENBAN> listCTBB;
        string idLogin = frmDN.idlogin;
        public frmHuyThuoc()
        {
            InitializeComponent();
        }

        private void BindGrid(List<CHITIETBIENBAN> listCTBB)
        {
            dgvHuyThuoc.Rows.Clear();
            foreach (var item in listCTBB)
            {
                THUOC t = db.THUOCs.SingleOrDefault(p => p.MATHUOC == item.MATHUOC);
                int index = dgvHuyThuoc.Rows.Add();
                dgvHuyThuoc.Rows[index].Cells[0].Value = item.MABB;

                DateTime tNLap = (DateTime)item.BIENBANHUYTHUOC.NGAYLAPBB;
                String dateInStringNLap = tNLap.ToString("dd/MM/yyyy");
                dgvHuyThuoc.Rows[index].Cells[1].Value = dateInStringNLap;

                DateTime tNHuy = (DateTime)item.NGAYHUY;
                String dateInStringNHuy = tNHuy.ToString("dd/MM/yyyy");
                dgvHuyThuoc.Rows[index].Cells[2].Value = dateInStringNHuy;

                dgvHuyThuoc.Rows[index].Cells[3].Value = item.THUOC.LOAITHUOC.MAKHO;
                dgvHuyThuoc.Rows[index].Cells[4].Value = t.TENTHUOC;
                dgvHuyThuoc.Rows[index].Cells[5].Value = item.SOLUONGHUY;

                DateTime tHSD = (DateTime)item.HSD;
                String dateInStringHSD = tHSD.ToString("dd/MM/yyyy");
                dgvHuyThuoc.Rows[index].Cells[6].Value = dateInStringHSD;

                dgvHuyThuoc.Rows[index].Cells[7].Value = item.BIENBANHUYTHUOC.TRANGTHAI;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void frmHuyThuoc_Load(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(p => p.MANV == frmDN.idlogin);
            lblTenNV.Text = nv.TENNV;
            ////Load cboKho
            String sql = "Select * From KHOTHUOC";
            cboKhoThuoc.DataSource = Database.Singleton.Execute(sql);
            cboKhoThuoc.ValueMember = "MAKHO";
            cboKhoThuoc.DisplayMember = "MAKHO";
            ////Load cboThuoc
            //String sql1 = "Select * From THUOC";
            //cboThuoc.DataSource = Database.Singleton.Execute(sql1);
            //cboThuoc.ValueMember = "MATHUOC";
            //cboThuoc.DisplayMember = "TENTHUOC";
            try
            {
                listCTBB = db.CHITIETBIENBANs.ToList();
                BindGrid(listCTBB);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        void ShowSL(int MaThuoc)
        {
            THUOC th = db.THUOCs.FirstOrDefault(p => p.MATHUOC == MaThuoc);
            if (th != null)
            {
                nudSoLuong.Text = th.SOLUONGTON.ToString();
            }
        }

        int LoadSL(int b)
        {
            int sl;

            THUOC lsl = db.THUOCs.SingleOrDefault(p => p.MATHUOC == b);
            sl = (int)lsl.SOLUONGTON;
            return sl;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Đã Tiêu Hủy
            try
            {
                if (this.cboKhoThuoc.Text.Trim() == "" || this.cboThuoc.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông Báo!");
                    return;
                }
                int a = 0;
                if (txtMaBB.Text.Length > 0)
                {
                    a = Int32.Parse(txtMaBB.Text);
                }
                string MK = cboKhoThuoc.Text;
                int MT = Int32.Parse(cboThuoc.SelectedValue.ToString());
                THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == MT && p.LOAITHUOC.MAKHO == MK);
                CHITIETBIENBAN findCTBB = db.CHITIETBIENBANs.SingleOrDefault(p => p.MABB == a && p.MATHUOC == MT);

                if (findTHUOC == null)
                {
                    MessageBox.Show("Không tìm thấy thuốc!", "Thông Báo");
                    return;
                }
                else
                {
                    //findCTBB.SOLUONGHUY = Int32.Parse(nudSoLuong.Text);
                    //Lấy số lượng tồn - số lượng hủy
                    findTHUOC.SOLUONGTON = findTHUOC.SOLUONGTON - findCTBB.SOLUONGHUY;
                    findCTBB.BIENBANHUYTHUOC.TRANGTHAI = true;
                    DateTime Now = DateTime.Now;
                    findCTBB.NGAYHUY = Now;

                    db.SaveChanges();
                    MessageBox.Show("Hủy thuốc thành công!", "Thông Báo!");
                }
                BindGrid(db.CHITIETBIENBANs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Đang Chờ
            try
            {
                if (this.cboKhoThuoc.Text.Trim() == "" || this.cboThuoc.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông Báo!");
                    return;
                }
                int a = 0;
                if (txtMaBB.Text.Length > 0)
                {
                    a = Int32.Parse(txtMaBB.Text);
                }

                string MK = cboKhoThuoc.Text;
                int MT = Int32.Parse(cboThuoc.SelectedValue.ToString());
                THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == MT && p.LOAITHUOC.MAKHO == MK);
                CHITIETBIENBAN findCTBB = db.CHITIETBIENBANs.FirstOrDefault(p => p.MABB == a);

                if (findCTBB == null)
                {
                    BIENBANHUYTHUOC bbht = new BIENBANHUYTHUOC();
                    DateTime Now = DateTime.Now;
                    bbht.NGAYLAPBB = Now;
                    bbht.MANV = frmDN.idlogin;
                    bbht.TRANGTHAI = false;

                    db.BIENBANHUYTHUOCs.Add(bbht);
                    db.SaveChanges();

                    int t = db.BIENBANHUYTHUOCs.Max(m => m.MABB);

                    findCTBB = new CHITIETBIENBAN();
                    findCTBB.MATHUOC = Int32.Parse(cboThuoc.SelectedValue.ToString());
                    findCTBB.MABB = t;
                    findCTBB.NGAYHUY = Now;
                    findCTBB.SOLUONGHUY = Int32.Parse(nudSoLuong.Text);
                    if (findCTBB.SOLUONGHUY != findTHUOC.SOLUONGTON)
                    {
                        MessageBox.Show("Vui lòng nhập đúng số lượng hủy!", "Thông Báo");
                        return;
                    }
                    findCTBB.HSD = dtpHSD.Value;
                    //Lấy hạn sử dụng thuốc
                    //findCTBB.HSD = findTHUOC.HANSUDUNG;

                    db.CHITIETBIENBANs.Add(findCTBB);
                    db.SaveChanges();

                    MessageBox.Show("Thêm biên bản chờ hủy thành công!", "Thông Báo!");
                }
                BindGrid(db.CHITIETBIENBANs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Refresh
            this.txtMaBB.Text = "";
            this.dtpNgayLap.Text = "";
            this.dtpNgayHuy.Text = "";
            this.cboKhoThuoc.Text = "";
            this.cboThuoc.Text = "";
            this.nudSoLuong.Text = "0";
            this.dtpHSD.Text = "";
            this.rdnCho.Checked = false;
            this.rdnHuy.Checked = false;
        }

        private void dgvHuyThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHuyThuoc.SelectedRows.Count > 0)
                {
                    txtMaBB.Text = dgvHuyThuoc.SelectedRows[0].Cells[0].Value.ToString();

                    DateTime NgayLap = DateTime.ParseExact(dgvHuyThuoc.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNgayLap.Text = NgayLap.ToShortDateString();
                    DateTime NgayHuy = DateTime.ParseExact(dgvHuyThuoc.SelectedRows[0].Cells[2].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNgayLap.Text = NgayHuy.ToShortDateString();

                    cboKhoThuoc.Text = dgvHuyThuoc.SelectedRows[0].Cells[3].Value.ToString();
                    cboThuoc.Text = dgvHuyThuoc.SelectedRows[0].Cells[4].Value.ToString();
                    nudSoLuong.Text = dgvHuyThuoc.SelectedRows[0].Cells[5].Value.ToString();

                    DateTime HSD = DateTime.ParseExact(dgvHuyThuoc.SelectedRows[0].Cells[6].Value.ToString(), "dd/MM/yyyy", null);
                    dtpHSD.Text = HSD.ToShortDateString();

                    if (dgvHuyThuoc.SelectedRows[0].Cells[7].Value.ToString().Equals("True"))
                    {
                        rdnHuy.Checked = true;
                        rdnCho.Checked = false;
                    }
                    else
                    {
                        rdnCho.Checked = true;
                        rdnHuy.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboThuoc_DropDownClosed(object sender, EventArgs e)
        {
            db = new Model1();
            THUOC th = db.THUOCs.SingleOrDefault(p => p.TENTHUOC == cboThuoc.Text);
            if (th != null)
            {
                nudSoLuong.Value = (Decimal)th.SOLUONGTON;
                dtpHSD.Value = (DateTime)th.HANSUDUNG;
            }
        }

        private void cboKhoThuoc_DropDownClosed(object sender, EventArgs e)
        {
            String sql = "SELECT A.* FROM THUOC A, LOAITHUOC B WHERE A.MALOAITHUOC = B.MALOAITHUOC AND B.MAKHO = '" + cboKhoThuoc.Text + "'";
            cboThuoc.DataSource = Database.Singleton.Execute(sql);
            cboThuoc.ValueMember = "MATHUOC";
            cboThuoc.DisplayMember = "TENTHUOC";
        }

        private void dgvHuyThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
