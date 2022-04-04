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
    public partial class frmThongTinThuoc : Form
    {
        Model1 db = new Model1();
        static string img = "";
        public frmThongTinThuoc()
        {
            InitializeComponent();
        }

        private void frmThongTinThuoc_Load(object sender, EventArgs e)
        {
            LoadThuocCbo();
        }
        void LoadThuocCbo()
        {
            String sql = "Select * From THUOC";
            cboThuoc.DataSource = Database.Singleton.Execute(sql);
            cboThuoc.ValueMember = "MATHUOC";
            cboThuoc.DisplayMember = "TENTHUOC";
        }
        void Show( int MaThuoc)
        {
            SetNull();
            THUOC thuoc = db.THUOCs.FirstOrDefault(p => p.MATHUOC == MaThuoc);
            if (thuoc != null)
            {
                txtLoaiThuoc.Text = thuoc.LOAITHUOC.TENLOAITHUOC;
                txtDVT.Text = thuoc.DVT;
                txtSoLuong.Text = thuoc.SOLUONGTON.ToString();
                dtpNgaySX.Value = DateTime.Parse(thuoc.NGAYSANXUAT.ToString());
                dtpNgayHH.Value = DateTime.Parse(thuoc.HANSUDUNG.ToString()); ;
                picHinhThuoc.ImageLocation = thuoc.HINHTHUOC;
                txtMoTa.Text = thuoc.MOTA;
            }
        }
        void SetNull()
        {
            txtLoaiThuoc.Text = "";
            txtDVT.Text = "";
            txtSoLuong.Text = "";
            picHinhThuoc.ImageLocation = null;
            txtMoTa.Text = "";
        }
        private void cboThuoc_DropDownClosed(object sender, EventArgs e)
        {       
            int a = Int32.Parse(cboThuoc.SelectedValue.ToString());
            
            Show(a);
        }

        private void cboThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
