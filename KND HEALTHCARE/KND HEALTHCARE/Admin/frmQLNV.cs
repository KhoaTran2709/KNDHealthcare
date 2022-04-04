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
    public partial class frmQLNV : Form
    {
        Model1 db = new Model1();
        List<NHANVIEN> listNV;
        static string img = "";
        public frmQLNV()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NHANVIEN> listNV)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in listNV)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.MANV;
                dgvNhanVien.Rows[index].Cells[1].Value = item.TENNV;
                dgvNhanVien.Rows[index].Cells[2].Value = item.GIOITINH;
                DateTime tmp = (DateTime)item.NGAYSINH;
                String dateInString = tmp.ToString("dd/MM/yyyy");
                dgvNhanVien.Rows[index].Cells[3].Value = dateInString;
                dgvNhanVien.Rows[index].Cells[4].Value = item.SDTNV;
                dgvNhanVien.Rows[index].Cells[5].Value = item.CHUCVU;
                dgvNhanVien.Rows[index].Cells[6].Value = item.HINHNV;
                dgvNhanVien.Rows[index].Cells[7].Value = item.MATKHAU;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoaNV_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txtHTNV.Text.Trim()==""||this.txtMaNV.Text.Trim()==""||this.picHinhNV.ImageLocation ==null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên !");
                    return;
                }
                if(this.txtMaNV.Text.Length !=10)
                {
                    MessageBox.Show("Phải nhập đủ 10 kí tự cho nhân viên !");
                    return;
                }
                if ( this.txtMatKhau.Text.Length < 9)
                {
                    MessageBox.Show("Mật Khẩu phải từ 10 kí tự trở lên !");
                }
                NHANVIEN findNV = db.NHANVIENs.FirstOrDefault(p => p.MANV == txtMaNV.Text);
                
                if(findNV == null)
                {
                    findNV = new NHANVIEN();
                    findNV.MANV = txtMaNV.Text;
                    findNV.TENNV = txtHTNV.Text;
                    if (rdnNam.ToString().Equals("True"))
                    {
                        findNV.GIOITINH = rdnNam.Checked;
                    }
                    else
                    {
                        findNV.GIOITINH = rdnNu.Checked;
                    }
                    findNV.NGAYSINH = dtpNTNS.Value;
                    findNV.SDTNV = txtSDT.Text;
                    findNV.CHUCVU = cboCVu.SelectedItem.ToString();
                    findNV.HINHNV = img;
                    findNV.MATKHAU = txtMatKhau.Text;

                    db.NHANVIENs.Add(findNV);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới nah6n viên thành công !", "Thông Báo");
                    }
                else
                {
                    string xpathNV = findNV.HINHNV;
                    findNV.TENNV = txtHTNV.Text;
                    findNV.NGAYSINH = dtpNTNS.Value;
                    if (rdnNam.ToString().Equals("True"))
                    {
                        findNV.GIOITINH = rdnNam.Checked;
                    }
                    else
                    {
                        findNV.GIOITINH = rdnNu.Checked;
                    }
                    findNV.NGAYSINH = dtpNTNS.Value;
                    findNV.SDTNV = txtSDT.Text;
                    findNV.CHUCVU = cboCVu.SelectedItem.ToString();
                    //Lấy hình cũ từ CSDL~~~~~~~~~~~~~~~~~~~
                    findNV.HINHNV = picHinhNV.ImageLocation;
                    
                    //~~~~~~~~~~~~~~~~~~~
                    findNV.MATKHAU = txtMatKhau.Text;

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
                BindGrid(db.NHANVIENs.ToList());
            }catch (Exception ex)
            {
                MessageBox.Show(null);
            }
        }
        
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                path = new OpenFileDialog();
                path.Filter = "JPG Files (*.jpg)|*.jpg|JPG Files (*.png)|*.png|All Files (*.*)|*.*";
                path.Title = "Chọn hình ảnh";
                if (path.ShowDialog() == DialogResult.OK)
                {
                    img = path.FileName.ToString();
                    picHinhNV.ImageLocation = img;
                    MessageBox.Show(path.FileName.ToString());
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            try
            {
                listNV = db.NHANVIENs.ToList();
                BindGrid(listNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    txtMaNV.Text = dgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                    txtHTNV.Text = dgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                    if(dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString().Equals("True"))
                    {
                        rdnNam.Checked = true;
                        rdnNu.Checked = false;
                    }
                    else
                    {
                        rdnNu.Checked = true;
                        rdnNam.Checked = false;
                    }
                    //rdnNam.Checked = dgvNhanVien.SelectedRows[0].Cells[2].Value.ToString(); giới tính
                    DateTime ns = DateTime.ParseExact(dgvNhanVien.SelectedRows[0].Cells[3].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNTNS.Text = ns.ToShortDateString();
                    txtSDT.Text = dgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
                    cboCVu.Text = dgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
                    picHinhNV.ImageLocation = dgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();
                    txtMatKhau.Text = dgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();
                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void cboCVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picHinhNV_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.txtHTNV.Text = "";
            this.txtMaNV.Text = "";
            this.txtMatKhau.Text = "";
            this.txtSDT.Text = "";
            this.cboCVu.Text = "";
            this.dtpNTNS.Text = "";
            this.picHinhNV.ImageLocation = null;
            this.rdnNam.Checked = true;
            this.rdnNu.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtHTNV.Text.Trim() == "" || this.txtMaNV.Text.Trim() == "" || this.picHinhNV.ImageLocation == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên !");
                    return;
                }
                if (this.txtMaNV.Text.Length != 10)
                {
                    MessageBox.Show("Phải nhập đủ 10 kí tự cho nhân viên !");
                    return;
                }
                if (this.txtMatKhau.Text.Length < 9)
                {
                    MessageBox.Show("Mật Khẩu phải từ 10 kí tự trở lên !");
                }
                NHANVIEN findNV = db.NHANVIENs.FirstOrDefault(p => p.MANV == txtMaNV.Text);

                if (findNV == null)
                {
                    findNV = new NHANVIEN();
                    findNV.MANV = txtMaNV.Text;
                    findNV.TENNV = txtHTNV.Text;
                    if (rdnNam.ToString().Equals("True"))
                    {
                        findNV.GIOITINH = rdnNam.Checked;
                    }
                    else
                    {
                        findNV.GIOITINH = rdnNu.Checked;
                    }
                    findNV.NGAYSINH = dtpNTNS.Value;
                    findNV.SDTNV = txtSDT.Text;
                    findNV.CHUCVU = cboCVu.SelectedItem.ToString();
                    findNV.HINHNV = img;
                    findNV.MATKHAU = SHA_256.Hash(txtMatKhau.Text);

                    db.NHANVIENs.Add(findNV);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới nhân viên thành công !", "Thông Báo");
                }
                else
                {
                    string xpathNV = findNV.HINHNV;
                    findNV.TENNV = txtHTNV.Text;
                    findNV.NGAYSINH = dtpNTNS.Value;
                    if (rdnNam.ToString().Equals("True"))
                    {
                        findNV.GIOITINH = rdnNam.Checked;
                    }
                    else
                    {
                        findNV.GIOITINH = rdnNu.Checked;
                    }
                    findNV.NGAYSINH = dtpNTNS.Value;
                    findNV.SDTNV = txtSDT.Text;
                    findNV.CHUCVU = cboCVu.SelectedItem.ToString();
                    //Lấy hình cũ từ CSDL~~~~~~~~~~~~~~~~~~~
                    findNV.HINHNV = picHinhNV.ImageLocation;

                    //~~~~~~~~~~~~~~~~~~~
                    findNV.MATKHAU = SHA_256.Hash(txtMatKhau.Text);

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
                BindGrid(db.NHANVIENs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(null);
            }
        }

        private void RefreshItem_Click(object sender, EventArgs e)
        {
            string nv = db.NHANVIENs.Max(p => p.MANV);
            decimal temp = decimal.Parse(nv);
            this.txtHTNV.Text = "";
            this.txtMaNV.Text = (temp + 1).ToString();
            this.txtMatKhau.Text = "";
            this.txtSDT.Text = "";
            this.cboCVu.Text = "";
            this.dtpNTNS.Text = "";
            this.picHinhNV.ImageLocation = null;
            this.rdnNam.Checked = false;
            this.rdnNu.Checked = false;
        }

        private void MenuQLNV_Opening(object sender, CancelEventArgs e)
        {

        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN foundNV = db.NHANVIENs.SingleOrDefault(p => p.MANV == txtMaNV.Text);
                if(foundNV == null)
                {
                    MessageBox.Show("Không tim thấy đối tượng cần xóa");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.NHANVIENs.Remove(foundNV);
                        db.SaveChanges();
                        BindGrid(db.NHANVIENs.ToList());
                    }
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Bạn không thể xóa nhân viên này !","Thông Báo");
            }

        }
    }
}
