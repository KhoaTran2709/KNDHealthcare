using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using KND_HEALTHCARE.Models;
using KND_HEALTHCARE.Report;

namespace KND_HEALTHCARE
{
    public partial class frmBanThuoc : Form
    {
        Model1 db = new Model1();
        List<CHITIETPHIEUMUATHUOC> listCTPMT;
        List<CHITIETPHIEUMUATHUOC> temp = new List<CHITIETPHIEUMUATHUOC>();
        int TongTien = 0;
        public frmBanThuoc()
        {
            InitializeComponent();
        }
        void Show(int MaThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(p => p.MATHUOC == MaThuoc);
            if (thuoc != null)
            {
                txtDVT.Text = thuoc.DVT;
                txtSoLuong.Text = thuoc.SOLUONGTON.ToString();
            }
        }
        void LoadThuocCbo()
        {
            String sql = "Select * From THUOC";
            cboThuoc.DataSource = Database.Singleton.Execute(sql);
            cboThuoc.ValueMember = "MATHUOC";
            cboThuoc.DisplayMember = "TENTHUOC";
        }
        void BindGrid(List<CHITIETPHIEUMUATHUOC> lst)
        {
            dgvBanThuoc.Rows.Clear();
            foreach (var item in lst)
            {
                THUOC temp = db.THUOCs.SingleOrDefault(p => p.MATHUOC == item.MATHUOC);
                int index = dgvBanThuoc.Rows.Add();
                dgvBanThuoc.Rows[index].Cells[0].Value = item.MATHUOC;
                dgvBanThuoc.Rows[index].Cells[1].Value = temp.TENTHUOC;
                dgvBanThuoc.Rows[index].Cells[2].Value = temp.DVT;
                dgvBanThuoc.Rows[index].Cells[3].Value = temp.DONGIA;
                dgvBanThuoc.Rows[index].Cells[4].Value = item.SOLUONGMUA;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int LaySoLuong(int a)
        {
            int sl;

            THUOC laysl = db.THUOCs.SingleOrDefault(p => p.MATHUOC == a);
            sl = (int)laysl.SOLUONGTON;
            return sl;
        }
        private void frmBanThuoc_Load(object sender, EventArgs e)
        {
            LoadThuocCbo();

        }

        void DemTien()
        {
            decimal tongtien = 0;
            for (int i = 0; i < temp.Count; i++)
            {
                tongtien += (int)(temp[i].SOLUONGMUA * temp[i].DONGIATHUOC);
            }
            txtThanhTien.Text = tongtien.ToString();
            BindGrid(temp);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if(temp.Count == 0)
            {
                CHITIETPHIEUMUATHUOC ctpmt = new CHITIETPHIEUMUATHUOC();
                ctpmt.MATHUOC = Int32.Parse(cboThuoc.SelectedValue.ToString());
                ctpmt.SOLUONGMUA = Int32.Parse(txtSoLuong.Text);
                THUOC findThuoc = db.THUOCs.SingleOrDefault(p => p.MATHUOC == ctpmt.MATHUOC);
                ctpmt.DONGIATHUOC = findThuoc.DONGIA;
                temp.Add(ctpmt);
                //TongTien += (int)(ctpmt.SOLUONGMUA * ctpmt.DONGIATHUOC);
            }
            else 
            {
                int d = 0;
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].MATHUOC == Int32.Parse(cboThuoc.SelectedValue.ToString()))
                    {
                        temp[i].SOLUONGMUA = temp[i].SOLUONGMUA + Int32.Parse(txtSoLuong.Text);
                        int m = temp[i].MATHUOC;
                        THUOC findThuoc = db.THUOCs.SingleOrDefault(p => p.MATHUOC == m);
                        //TongTien += (int)(temp[i].SOLUONGMUA * findThuoc.DONGIA);
                        //txtThanhTien.Text = TongTien.ToString();
                        d++;
                    }
                    
                }
                if(d==0)
                {
                    CHITIETPHIEUMUATHUOC ctpmt = new CHITIETPHIEUMUATHUOC();
                    ctpmt.MATHUOC = Int32.Parse(cboThuoc.SelectedValue.ToString());
                    ctpmt.SOLUONGMUA = Int32.Parse(txtSoLuong.Text);
                    THUOC findThuoc = db.THUOCs.SingleOrDefault(p => p.MATHUOC == ctpmt.MATHUOC);
                    ctpmt.DONGIATHUOC = findThuoc.DONGIA;
                    temp.Add(ctpmt);    
                }
                
            }
            DemTien();
            BindGrid(temp);

            //txtThanhTien.Text = TongTien.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG findKhachHang = db.KHACHHANGs.SingleOrDefault(p => p.SDTKHACHHANG == txtSDT.Text);
                if (findKhachHang == null)
                {
                    MessageBox.Show("Chưa có thông tin khách !!!");
                    return;
                }
                //tạo mới phiếu mua
                PHIEUMUATHUOC PMT = new PHIEUMUATHUOC();
                DateTime now = DateTime.Now;
                PMT.NGAYMUA = now;
                PMT.SDTKHACHHANG = txtSDT.Text;
                PMT.TONGTIEN = 0;
                db.PHIEUMUATHUOCs.Add(PMT);
                db.SaveChanges();
                //thêm chi tiết phiếu mua vào ==> phiếu mua
                int t = db.PHIEUMUATHUOCs.Max(p => p.SOPHIEUMUA);
                decimal tongtien = 0;
                for (int i = 0; i < temp.Count; i++)
                {
                    CHITIETPHIEUMUATHUOC CTPMT = new CHITIETPHIEUMUATHUOC();
                    CTPMT.SOPHIEUMUA = t;
                    CTPMT.MATHUOC = temp[i].MATHUOC;
                    CTPMT.SOLUONGMUA = temp[i].SOLUONGMUA;
                    CTPMT.DONGIATHUOC = temp[i].DONGIATHUOC;
                    tongtien += (int)(temp[i].SOLUONGMUA * temp[i].DONGIATHUOC);
                    db.CHITIETPHIEUMUATHUOCs.Add(CTPMT);
                    db.SaveChanges();
                    // trừ số lượng mua trong số lượng tồn
                    int s = temp[i].MATHUOC;
                    THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == s);
                    if (findTHUOC != null)
                    {
                        findTHUOC.SOLUONGTON = findTHUOC.SOLUONGTON - temp[i].SOLUONGMUA;
                        db.SaveChanges();
                    }
                }
                PMT.TONGTIEN = tongtien;
                db.SaveChanges();
                txtThanhTien.Text = tongtien.ToString();
                temp.Clear();
                BindGrid(temp);
                rptPhieuMua frmHDN = new rptPhieuMua();
                frmHDN.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cboThuoc_DropDownClosed(object sender, EventArgs e)
        {
            int a = Int32.Parse(cboThuoc.SelectedValue.ToString());
            Show(a);
            int slt = LaySoLuong(a);
            txtSoLuong.Maximum = slt;
        }

        private void dgvBanThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (dgvBanThuoc.SelectedRows.Count > 0)
                {
                    cboThuoc.Text = dgvBanThuoc.SelectedRows[0].Cells[1].Value.ToString();
                    txtDVT.Text = dgvBanThuoc.SelectedRows[0].Cells[2].Value.ToString();
                    txtSoLuong.Value = Int32.Parse(dgvBanThuoc.SelectedRows[0].Cells[4].Value.ToString());
                    
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int t = db.PHIEUMUATHUOCs.Max(p => p.SOPHIEUMUA);
            decimal tongtien = 0;
            try
            {
                if (dgvBanThuoc.SelectedRows.Count > 0)
                {
                    int a = int.Parse(cboThuoc.SelectedValue.ToString());
                    var ctpmt = temp.Single(p => p.MATHUOC == a);
                    temp.Remove(ctpmt);
                    for (int i = 0; i < temp.Count; i++)
                    {
                        tongtien += (int)(temp[i].SOLUONGMUA * temp[i].DONGIATHUOC);
                    }
                    txtThanhTien.Text = tongtien.ToString() ;
                    BindGrid(temp);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            decimal tongtien = 0;
            for (int i=0;i<temp.Count;i++)
            {
                tongtien += (int)(temp[i].SOLUONGMUA * temp[i].DONGIATHUOC);
            }
            txtThanhTien.Text = tongtien.ToString();
            BindGrid(temp);
        }
    }
}
