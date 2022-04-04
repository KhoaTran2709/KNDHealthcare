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
using System.Data.SqlClient;
using System.Data;

namespace KND_HEALTHCARE
{
    public partial class frmNCC : Form
    {
        Model1 db = new Model1();
        List<NHACUNGCAP> listNCC;
        public frmNCC()
        {
            InitializeComponent();
        }
        private void BindGrid(List<NHACUNGCAP> listNCC)
        {
            dgvNCC.Rows.Clear();
            foreach (var item in listNCC)
            {
                int index = dgvNCC.Rows.Add();
                dgvNCC.Rows[index].Cells[0].Value = item.MANCC;
                dgvNCC.Rows[index].Cells[1].Value = item.TENNCC;
                dgvNCC.Rows[index].Cells[2].Value = item.DIACHI;
                dgvNCC.Rows[index].Cells[3].Value = item.SDT;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            try
            {
                listNCC = db.NHACUNGCAPs.ToList();
                BindGrid(listNCC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLuu_Click_1(object sender, EventArgs e)
        {
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNCC.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChiNCC.ReadOnly = false;
           
            try
            {
                if (dgvNCC.SelectedRows.Count > 0)
                {
                    txtMaNCC.Text = dgvNCC.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenNCC.Text = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
                    txtDiaChiNCC.Text = dgvNCC.SelectedRows[0].Cells[2].Value.ToString();
                    txtSDT.Text = dgvNCC.SelectedRows[0].Cells[3].Value.ToString();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChiNCC.Text = "";
            txtSDT.Text = "";
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                int a = int.Parse(txtMaNCC.Text);
                NHACUNGCAP findNCC = db.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == a);
                if (findNCC == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.NHACUNGCAPs.Remove(findNCC);
                        db.SaveChanges();
                        MessageBox.Show("Xóa Thành Công!");
                    }
                }
                BindGrid(db.NHACUNGCAPs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có đối tượng cần xóa !", "Thông báo");
                return;
            }
        }

        private void RefreshItem_Click(object sender, EventArgs e)
        {
            txtTenNCC.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChiNCC.ReadOnly = false;
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChiNCC.Text = "";
            txtSDT.Text = "";
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (txtMaNCC.Text.Length > 0)
            {
                a = Int32.Parse(txtMaNCC.Text);
            }

            NHACUNGCAP findNCC = db.NHACUNGCAPs.FirstOrDefault(p => p.MANCC == a);
            try
            {


                if (this.txtTenNCC.Text.Trim() == "" || this.txtDiaChiNCC.Text.Trim() == "" || this.txtSDT.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                    return;
                }

                if (findNCC == null)
                {
                    findNCC = new NHACUNGCAP();
                    findNCC.TENNCC = txtTenNCC.Text;
                    findNCC.DIACHI = txtDiaChiNCC.Text;
                    findNCC.SDT = txtSDT.Text;

                    db.NHACUNGCAPs.Add(findNCC);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới nhà cung cấp thành công !", "Thông Báo");
                }
                else
                {
                    try
                    {
                        if (findNCC != null)
                        {
                            findNCC.TENNCC = txtTenNCC.Text;
                            findNCC.DIACHI = txtDiaChiNCC.Text;
                            findNCC.SDT = txtSDT.Text;

                            db.SaveChanges();
                            MessageBox.Show("Cập nhật nhà cung cấp thành công", "Thông báo");

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(null);
                    }
                }
                BindGrid(db.NHACUNGCAPs.ToList());
                txtMaNCC.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(null);
            }
        }

        private void AddItem_Click_1(object sender, EventArgs e)
        {
            txtTenNCC.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChiNCC.ReadOnly = false;
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChiNCC.Text = "";
            txtSDT.Text = "";
        }
    }
}
