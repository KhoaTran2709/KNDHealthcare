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
using System.Data.SqlClient;
using System.Data;
namespace KND_HEALTHCARE
{
    public partial class frmQLLoaiThuoc : Form
    {
        List<LOAITHUOC> listLT;
        Model1 db = new Model1();
        public frmQLLoaiThuoc()
        {
            InitializeComponent();
        }
        private void BindGrid(List<LOAITHUOC> listLT)
        {
            dgv_LoaiThuoc.Rows.Clear();
            foreach (var item in listLT)
            {
                int index = dgv_LoaiThuoc.Rows.Add();
                dgv_LoaiThuoc.Rows[index].Cells[0].Value = item.MALOAITHUOC;
                dgv_LoaiThuoc.Rows[index].Cells[1].Value = item.TENLOAITHUOC;
                dgv_LoaiThuoc.Rows[index].Cells[2].Value = item.GHICHU;
                dgv_LoaiThuoc.Rows[index].Cells[3].Value = item.MAKHO;
            }
        }
        private void setButton()
        {
            cboMaKho.Enabled = true;
            txtTenLoaiThuoc.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
        }
        private void frmQLLoaiThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                cboMaKho.Enabled = true;
                listLT = db.LOAITHUOCs.ToList();
                BindGrid(listLT);
                
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_LoaiThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGhiChu.Text = "";
            try
            {
                if (dgv_LoaiThuoc.SelectedRows.Count > 0)
                {
                    txtMaLoaiThuoc.Text = dgv_LoaiThuoc.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenLoaiThuoc.Text = dgv_LoaiThuoc.SelectedRows[0].Cells[1].Value.ToString();
                    txtGhiChu.Text = dgv_LoaiThuoc.SelectedRows[0].Cells[2].Value.ToString();
                    cboMaKho.Text = dgv_LoaiThuoc.SelectedRows[0].Cells[3].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }



        private void cboMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                List<LOAITHUOC> LT = db.LOAITHUOCs.Where(p => p.MAKHO == cboMaKho.Text).ToList();
                if (LT.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                }
                BindGrid(LT);

            }
            catch(Exception ex)
            {
               
            }
        }

        private void cboMaKho_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cboMaKho.Text.Trim() == "" || this.txtTenLoaiThuoc.Text.Trim() == ""  || this.txtGhiChu.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc !");
                    return;
                }
                
                
                LOAITHUOC findLOAITHUOC = db.LOAITHUOCs.FirstOrDefault(p => p.TENLOAITHUOC == txtTenLoaiThuoc.Text && p.MAKHO == cboMaKho.Text);
                if(findLOAITHUOC != null)
                {
                    MessageBox.Show("Không được phép nhập trùng 2 loại thuốc trong cùng 1 kho", "Thông báo");
                    return;
                }
                if (findLOAITHUOC == null )
                {
                    findLOAITHUOC = new LOAITHUOC ();
                    findLOAITHUOC.TENLOAITHUOC = txtTenLoaiThuoc.Text;
                    findLOAITHUOC.GHICHU = txtGhiChu.Text;
                    findLOAITHUOC.MAKHO = cboMaKho.SelectedItem.ToString();
                    db.LOAITHUOCs.Add(findLOAITHUOC);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Loại Thuốc thành công !", "Thông Báo");
                }
                
                BindGrid(db.LOAITHUOCs.ToList());
                setButton();
                txtMaLoaiThuoc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenLoaiThuoc.Enabled = false;
            try
            {
                LOAITHUOC findLoaiThuoc = db.LOAITHUOCs.FirstOrDefault(p => p.TENLOAITHUOC == txtTenLoaiThuoc.Text && p.MAKHO == cboMaKho.Text);

                if (findLoaiThuoc != null)
                {
                    findLoaiThuoc.GHICHU = txtGhiChu.Text;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật loại thuốc thành công", "Thông báo");

                }
                BindGrid(db.LOAITHUOCs.ToList());
                txtMaLoaiThuoc.Text = "";
                setButton();
                //MessageBox.Show(cboMaKho.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null);
            }
        }

        private void MenuQLLoaiThuoc_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            cboMaKho.Enabled = true;
            txtGhiChu.ReadOnly = false;
            txtTenLoaiThuoc.ReadOnly = false;
            txtTenLoaiThuoc.Enabled = true;
            txtGhiChu.Text = "";
            txtMaLoaiThuoc.Text = "";
            txtTenLoaiThuoc.Text = "";
            cboMaKho.Text = "";
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            cboMaKho.Enabled = false;
            txtTenLoaiThuoc.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LOAITHUOC findLoaiThuoc = db.LOAITHUOCs.FirstOrDefault(p => p.TENLOAITHUOC == txtTenLoaiThuoc.Text);
            try
            {
                
                //LOAITHUOC findMaKho = db.LOAITHUOCs.FirstOrDefault(p => p.MAKHO == cboMaKho.SelectedItem.ToString());
                if (findLoaiThuoc == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.LOAITHUOCs.Remove(findLoaiThuoc);
                        db.SaveChanges();
                        
                        MessageBox.Show("Xóa Thành Công!");

                    }
                }
                BindGrid(db.LOAITHUOCs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do vẫn còn dính tới dữ liệu !", "Thông báo");
                return;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = "";
            txtMaLoaiThuoc.Text = "";
            txtTenLoaiThuoc.Text = "";
            cboMaKho.Text = "";
            BindGrid(db.LOAITHUOCs.ToList());
        }
    }
}
