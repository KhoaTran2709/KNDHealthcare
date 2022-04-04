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
    public partial class frmResetPass : Form
    {
        Model1 db = new Model1();
        public frmResetPass()
        {
            InitializeComponent();
        }

        private void btnBackDN_Click(object sender, EventArgs e)
        {
            
            frmDN login = new frmDN();
            login.Show();
            this.Visible = false;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string reid = txtReID.Text;
            if(id.Equals(reid)==false)
            {
                MessageBox.Show("ID và Re-ID Không trùng khớp với nhau !");
            }
            else
            {
                NHANVIEN nv = db.NHANVIENs.SingleOrDefault(n => n.MANV == id);
                if (nv == null)
                {
                    MessageBox.Show("Không tồn tại Nhân Viên này !");
                }
                else
                {
                    nv.MATKHAU = SHA_256.Hash(reid);
                    db.SaveChanges();
                    MessageBox.Show("Khôi phục mật khẩu thành công !");

                }
            }
        }

        private void frmResetPass_Load(object sender, EventArgs e)
        {

        }
    }
}
