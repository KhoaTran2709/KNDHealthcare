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

namespace KND_HEALTHCARE.Staff
{
    public partial class frmNhapThuoc : Form
    {
        Model1 db = new Model1();
        List<PHIEUDATMUA> listPDM;
        Model1 d = new Model1();
        List<CHITIETPHIEUDATMUA> listCTPDM;

        public frmNhapThuoc()
        {
            InitializeComponent();
        }
        private void BindGrid1(List<PHIEUDATMUA> listPDM)
        {
            dgvNhapThuoc.Rows.Clear();
            foreach (var item in listPDM)
            {
                int index = dgvNhapThuoc.Rows.Add();
                dgvNhapThuoc.Rows[index].Cells[0].Value = item.SOPHIEUDAT;
                DateTime tmp = (DateTime)item.NGAYMUA;
                String dateInString = tmp.ToString("dd/MM/yyyy");
                dgvNhapThuoc.Rows[index].Cells[1].Value = dateInString;
                dgvNhapThuoc.Rows[index].Cells[2].Value = item.THANHTIEN;
                dgvNhapThuoc.Rows[index].Cells[3].Value = item.MANV;
                dgvNhapThuoc.Rows[index].Cells[4].Value = item.NHACUNGCAP.TENNCC;
            }
        }
        private void BindGrid2(List<CHITIETPHIEUDATMUA> listCTPDM)
        {
            dgvChiTiet.Rows.Clear();
            foreach (var item in listCTPDM)
            {
                int index = dgvChiTiet.Rows.Add();
                dgvChiTiet.Rows[index].Cells[0].Value = item.SOPHIEUDAT;
                dgvChiTiet.Rows[index].Cells[1].Value = item.THUOC.TENTHUOC;
                dgvChiTiet.Rows[index].Cells[2].Value = item.SOLUONGMUA;
            }
        }

        private void frmNhapThuoc_Load(object sender, EventArgs e)
        {
            String sql = "Select * From THUOC";
            cboThuoc.DataSource = Database.Singleton.Execute(sql);
            cboThuoc.ValueMember = "MATHUOC";
            cboThuoc.DisplayMember = "TENTHUOC";

            String sq = "Select * From PHIEUDATMUA";
            cboMaPhieu.DataSource = Database.Singleton.Execute(sq);
            cboMaPhieu.ValueMember = "SOPHIEUDAT";
            cboMaPhieu.DisplayMember = "SOPHIEUDAT";

            String ncc = "Select * From NHACUNGCAP";
            cboNCC.DataSource = Database.Singleton.Execute(ncc);
            cboNCC.ValueMember = "MANCC";
            cboNCC.DisplayMember = "TENNCC";

            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(p => p.MANV == frmDN.idlogin);
            lblMaNV.Text = nv.MANV;

            try
            {
                listPDM = db.PHIEUDATMUAs.ToList();
                BindGrid1(listPDM);
                listCTPDM = db.CHITIETPHIEUDATMUAs.ToList();
                BindGrid2(listCTPDM);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhapThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNhapThuoc.SelectedRows.Count > 0)
                {
                    txtMaPhieu.Text = dgvNhapThuoc.SelectedRows[0].Cells[0].Value.ToString();
                    DateTime ns = DateTime.ParseExact(dgvNhapThuoc.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNgayLap.Text = ns.ToShortDateString();
                    txtThanhTien.Text = dgvNhapThuoc.SelectedRows[0].Cells[2].Value.ToString();
                    lblMaNV.Text = dgvNhapThuoc.SelectedRows[0].Cells[3].Value.ToString();
                    cboNCC.Text = dgvNhapThuoc.SelectedRows[0].Cells[4].Value.ToString();
                }

            }
            catch (Exception ex)
            {

            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtMaPhieu.Text);
            PHIEUDATMUA findPDM = db.PHIEUDATMUAs.FirstOrDefault(p => p.SOPHIEUDAT == a);
            try
            {

                if (findPDM == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.PHIEUDATMUAs.Remove(findPDM);
                        db.SaveChanges();
                        MessageBox.Show("Xóa Thành Công!");
                    }
                }
                BindGrid1(db.PHIEUDATMUAs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do vẫn còn dính tới dữ liệu !", "Thông báo");
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(txtMaPhieu.Text);

                PHIEUDATMUA findPDM = db.PHIEUDATMUAs.SingleOrDefault(p => p.SOPHIEUDAT == a);
                if (findPDM != null)
                {
                    findPDM.THANHTIEN = decimal.Parse(txtThanhTien.Text);
                    findPDM.MANV = lblMaNV.Text;
                    findPDM.MANCC = int.Parse(cboNCC.SelectedValue.ToString());
                    findPDM.NGAYMUA = dtpNgayLap.Value;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo!");
                }
                BindGrid1(db.PHIEUDATMUAs.ToList());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtThanhTien.Text.Trim() == "" || this.lblMaNV.Text.Trim() == "" || this.cboNCC.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo!");
                    return;
                }

                int a = 0;
                if (txtMaPhieu.Text.Length > 0)
                {
                    a = Int32.Parse(txtMaPhieu.Text);
                }

                PHIEUDATMUA findPDM = db.PHIEUDATMUAs.SingleOrDefault(p => p.SOPHIEUDAT == a);

                if (findPDM == null)
                {
                    findPDM = new PHIEUDATMUA();
                    findPDM.THANHTIEN = decimal.Parse(txtThanhTien.Text);
                    findPDM.MANV = lblMaNV.Text;
                    findPDM.MANCC = int.Parse(cboNCC.SelectedValue.ToString());
                    findPDM.NGAYMUA = dtpNgayLap.Value;

                    db.PHIEUDATMUAs.Add(findPDM);

                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công!", "Thông Báo!");
                }
                BindGrid1(db.PHIEUDATMUAs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            if (cboMaPhieu.Text.Length > 0)
            {
                a = int.Parse(cboMaPhieu.SelectedValue.ToString());
            }
            if (cboThuoc.Text.Length > 0)
            {
                b = int.Parse(cboThuoc.SelectedValue.ToString());
            }
            int TT = Int32.Parse(cboThuoc.SelectedValue.ToString());
            THUOC findTHUOC = d.THUOCs.SingleOrDefault(p => p.MATHUOC == TT);
            CHITIETPHIEUDATMUA findCTPDM = d.CHITIETPHIEUDATMUAs.SingleOrDefault(p => p.SOPHIEUDAT == a && p.MATHUOC == b);
            try
            {
                if (findCTPDM != null)
                {
                    MessageBox.Show("Không thể nhập trùng thuốc trong 1 phiếu!", "Thông Báo!");
                    return;
                }
                else if (this.txtSoLuong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo!");
                    return;
                }

                else
                {
                    findCTPDM = new CHITIETPHIEUDATMUA();
                    findCTPDM.SOPHIEUDAT = int.Parse(cboMaPhieu.SelectedValue.ToString());
                    findCTPDM.SOLUONGMUA = int.Parse(txtSoLuong.Text);
                    findCTPDM.MATHUOC = int.Parse(cboThuoc.SelectedValue.ToString());
                    d.CHITIETPHIEUDATMUAs.Add(findCTPDM);
                    findTHUOC.SOLUONGTON = findTHUOC.SOLUONGTON + findCTPDM.SOLUONGMUA;
                    d.SaveChanges();
                    MessageBox.Show("Thêm mới thành công!", "Thông Báo!");
                }

                BindGrid2(db.CHITIETPHIEUDATMUAs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cboThuoc.Enabled = false;
            cboMaPhieu.Enabled = false;
            txtSoLuong.ReadOnly = true;
            try
            {
                if (dgvChiTiet.SelectedRows.Count > 0)
                {
                    cboMaPhieu.Text = dgvChiTiet.SelectedRows[0].Cells[0].Value.ToString();
                    cboThuoc.Text = dgvChiTiet.SelectedRows[0].Cells[1].Value.ToString();
                    txtSoLuong.Text = dgvChiTiet.SelectedRows[0].Cells[2].Value.ToString();

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            if (cboMaPhieu.Text.Length > 0)
            {
                a = int.Parse(cboMaPhieu.SelectedValue.ToString());
            }
            if (cboThuoc.Text.Length > 0)
            {
                b = int.Parse(cboThuoc.SelectedValue.ToString());
            }

            CHITIETPHIEUDATMUA findCTPDM = d.CHITIETPHIEUDATMUAs.SingleOrDefault(p => p.SOPHIEUDAT == a && p.MATHUOC == b); ;
            try
            {
                if (findCTPDM == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        d.CHITIETPHIEUDATMUAs.Remove(findCTPDM);
                        d.SaveChanges();
                        MessageBox.Show("Xóa Thành Công!");
                    }
                }
                BindGrid2(d.CHITIETPHIEUDATMUAs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do vẫn còn dính tới dữ liệu !", "Thông báo");
                return;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboThuoc.Enabled = true;
            cboMaPhieu.Enabled = true;
            txtSoLuong.ReadOnly = false;

            String sq = "Select * From PHIEUDATMUA";
            cboMaPhieu.DataSource = null;
            cboMaPhieu.DataSource = Database.Singleton.Execute(sq);
            cboMaPhieu.ValueMember = "SOPHIEUDAT";
            cboMaPhieu.DisplayMember = "SOPHIEUDAT";

            String sql = "Select * From THUOC";
            cboThuoc.DataSource = null;
            cboThuoc.DataSource = Database.Singleton.Execute(sql);
            cboThuoc.ValueMember = "MATHUOC";
            cboThuoc.DisplayMember = "TENTHUOC";

            String ncc = "Select * From NHACUNGCAP";
            cboNCC.DataSource = null;
            cboNCC.DataSource = Database.Singleton.Execute(ncc);
            cboNCC.ValueMember = "MANCC";
            cboNCC.DisplayMember = "TENNCC";

            db = new Model1();
            listPDM = db.PHIEUDATMUAs.ToList();
            BindGrid1(listPDM);
            txtMaPhieu.Text = "";
            txtThanhTien.Text = "";
            cboMaPhieu.Text = "";
            txtSoLuong.Text = "";
        }

        private void cboMaPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
