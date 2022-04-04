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
    public partial class frmMyUser : Form
    {
        Model1 db = new Model1();
        string idLogin = frmDN.idlogin;
        static string img = "";
        public frmMyUser()
        {
            InitializeComponent();
        }

        private void frmMyUser_Load(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(p => p.MANV == frmDN.idlogin);
            txtMaNV.Text = nv.MANV;
            txtTenNV.Text = nv.TENNV;
            if(nv.GIOITINH.Equals("False"))
            {
                rdnNam.Checked = false;
                rdnNu.Checked = true;
            }
            else
            {
                rdnNu.Checked = false;
                rdnNam.Checked = true;
            }
            picHinhNV.ImageLocation = nv.HINHNV;
            txtSDTNV.Text = nv.SDTNV;
            txtMatKhau.Text = nv.MATKHAU;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.txtMatKhau.Text.Length < 9)
            {
                MessageBox.Show("Mật Khẩu phải từ 10 kí tự trở lên !");
            }
            NHANVIEN findNV = db.NHANVIENs.FirstOrDefault(p => p.MANV == txtMaNV.Text);
            if(findNV != null)
            {
                string xpathNV = findNV.HINHNV;
                findNV.HINHNV = picHinhNV.ImageLocation;
                findNV.MATKHAU = SHA_256.Hash(txtMatKhau.Text);

                db.SaveChanges();
                MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
