using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KND_HEALTHCARE.Models;

namespace KND_HEALTHCARE
{
    public partial class frmDN : Form
    {
        Model1 db = new Model1();
        
        public static string idlogin;
        public frmDN()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            frmResetPass repass = new frmResetPass();
            repass.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPass repass = new frmResetPass();
            repass.Show();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPass repass = new frmResetPass();
            repass.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string pass = SHA_256.Hash(txtPass.Text);
                NHANVIEN nv = db.NHANVIENs.SingleOrDefault(n => n.MANV == id && n.MATKHAU == pass);
                if (nv == null)
                {
                    MessageBox.Show("Đăng Nhập Thất Bại !");
                }
                else
                {
                    frmMain main = new frmMain();
                    MessageBox.Show("Chào mừng bạn đã tới KND Healthcare");
                    idlogin = id;
                    main.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
