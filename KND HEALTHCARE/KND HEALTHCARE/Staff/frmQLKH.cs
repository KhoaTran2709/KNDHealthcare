using KND_HEALTHCARE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KND_HEALTHCARE
{
    public partial class frmQLKH : Form
    {
        Model1 db = new Model1();
        List<KHACHHANG> listKH;
        public frmQLKH()
        {
            InitializeComponent();
        }

        private void BindGrid(List<KHACHHANG> listKH)
        {
            dgvKH.Rows.Clear();
            foreach (var item in listKH)
            {
                int index = dgvKH.Rows.Add();
                dgvKH.Rows[index].Cells[0].Value = item.SDTKHACHHANG;
                dgvKH.Rows[index].Cells[1].Value = item.TENKHACHHANG;
                dgvKH.Rows[index].Cells[2].Value = item.DIACHI;
            }
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            try
            {
                listKH = db.KHACHHANGs.ToList();
                BindGrid(listKH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHTKH.ReadOnly = false;
            txtSDTKH.ReadOnly = true;
            txtDiaChi.ReadOnly = false;

            try
            {
                if (dgvKH.SelectedRows.Count > 0)
                {
                    txtSDTKH.Text = dgvKH.SelectedRows[0].Cells[0].Value.ToString();
                    txtHTKH.Text = dgvKH.SelectedRows[0].Cells[1].Value.ToString();
                    txtDiaChi.Text = dgvKH.SelectedRows[0].Cells[2].Value.ToString();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnKLuuKH_Click(object sender, EventArgs e)
        {
            txtSDTKH.Text = "";
            txtDiaChi.Text = "";
            txtSDTKH.Text = "";
        }

        private void txtSDTKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            KHACHHANG findKH = db.KHACHHANGs.FirstOrDefault(p => p.SDTKHACHHANG == txtSDTKH.Text);
            try
            {
                if (findKH == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.KHACHHANGs.Remove(findKH);
                        db.SaveChanges();
                        MessageBox.Show("Xóa Thành Công!");
                    }
                }
                BindGrid(db.KHACHHANGs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa do vẫn còn dính tới dữ liệu !", "Thông báo");
                return;
            }
            txtSDTKH.Focus();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {

        }

        private void RefreshItem_Click(object sender, EventArgs e)
        {
            txtDiaChi.ReadOnly = false;
            txtSDTKH.ReadOnly = false;
            txtHTKH.ReadOnly = false;
            txtHTKH.Text = "";
            txtDiaChi.Text = "";
            txtSDTKH.Text = "";
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            KHACHHANG findKH = db.KHACHHANGs.FirstOrDefault(p => p.SDTKHACHHANG == txtSDTKH.Text);
            try
            {
                if (this.txtSDTKH.Text.Trim() == "" || this.txtDiaChi.Text.Trim() == "" || this.txtHTKH.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                    return;
                }

                if (findKH == null)
                {
                    findKH = new KHACHHANG();
                    findKH.TENKHACHHANG = txtHTKH.Text;
                    findKH.DIACHI = txtDiaChi.Text;
                    findKH.SDTKHACHHANG = txtSDTKH.Text;

                    db.KHACHHANGs.Add(findKH);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới khách hàng thành công !", "Thông Báo");
                    txtSDTKH.Focus();
                    txtHTKH.Text = "";
                    txtDiaChi.Text = "";
                    txtSDTKH.Text = "";
                }
                else
                {
                    try
                    {
                        if (findKH != null)
                        {
                            findKH.TENKHACHHANG = txtHTKH.Text;
                            findKH.DIACHI = txtDiaChi.Text;
                            findKH.SDTKHACHHANG = txtSDTKH.Text;

                            db.SaveChanges();
                            MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo");

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(null);
                    }
                }
                BindGrid(db.KHACHHANGs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(null);
            }
        }
    }
}

        
