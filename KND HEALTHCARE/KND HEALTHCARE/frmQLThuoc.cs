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
    public partial class frmQLThuoc : Form
    {
        List<THUOC> listThuoc;
        Model1 db = new Model1();
        static string img = "";
        public frmQLThuoc()
        {
            InitializeComponent();
        }

        private void BindGrid(List<THUOC> listThuoc)
        {
            dgvQLT.Rows.Clear();
            foreach(var item in listThuoc)
            {
                int index = dgvQLT.Rows.Add();
                dgvQLT.Rows[index].Cells[0].Value = item.MATHUOC;
                dgvQLT.Rows[index].Cells[1].Value = item.TENTHUOC;
                dgvQLT.Rows[index].Cells[2].Value = item.DVT;
                dgvQLT.Rows[index].Cells[3].Value = item.DONGIA;
                dgvQLT.Rows[index].Cells[4].Value = item.SOLUONGTON;
                
                DateTime tNSX = (DateTime)item.NGAYSANXUAT;
                String dateInStringNSX = tNSX.ToString("dd/MM/yyyy");
                dgvQLT.Rows[index].Cells[5].Value = dateInStringNSX;

                DateTime tHSD = (DateTime)item.HANSUDUNG;
                String dateInStringHSD = tHSD.ToString("dd/MM/yyyy");
                dgvQLT.Rows[index].Cells[6].Value = dateInStringHSD;
                if(String.IsNullOrEmpty(item.HINHTHUOC))
                    dgvQLT.Rows[index].Cells[7].Value = "";
                else
                    dgvQLT.Rows[index].Cells[7].Value = item.HINHTHUOC;
                dgvQLT.Rows[index].Cells[8].Value = item.MOTA;
                dgvQLT.Rows[index].Cells[9].Value = item.LOAITHUOC.TENLOAITHUOC;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmQLThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                db = new Model1();
                listThuoc = db.THUOCs.ToList();
                BindGrid(listThuoc);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void dgvQLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLT.SelectedRows.Count > 0)
                {
                    txtMaThuoc.Text = dgvQLT.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenThuoc.Text = dgvQLT.SelectedRows[0].Cells[1].Value.ToString();

                    txtDVT.Text = dgvQLT.SelectedRows[0].Cells[2].Value.ToString();
                    txtDG.Text = dgvQLT.SelectedRows[0].Cells[3].Value.ToString();
                    txtSLT.Text = dgvQLT.SelectedRows[0].Cells[4].Value.ToString();

                    DateTime NSX = DateTime.ParseExact(dgvQLT.SelectedRows[0].Cells[5].Value.ToString(), "dd/MM/yyyy", null);
                    dtpNSX.Text = NSX.ToShortDateString();
                    DateTime HSD = DateTime.ParseExact(dgvQLT.SelectedRows[0].Cells[6].Value.ToString(), "dd/MM/yyyy", null);
                    dtpHSD.Text = HSD.ToShortDateString();
                    
                    if ( String.IsNullOrEmpty(dgvQLT.SelectedRows[0].Cells[7].Value.ToString()))
                    {
                        pbHinhThuoc.ImageLocation = "D:/Learn/[DA] DoAnChuyenNganh/icon/Picture/Zalo_636569097347690008.jpg";
                    }
                    else
                    {
                        pbHinhThuoc.ImageLocation = dgvQLT.SelectedRows[0].Cells[7].Value.ToString();
                    }
                    if(dgvQLT.SelectedRows[0].Cells[8].Value.ToString().Length == 0)
                    {
                        txtMoTa.Text = "";
                    }
                    else
                        txtMoTa.Text = dgvQLT.SelectedRows[0].Cells[8].Value.ToString();
                    cboLoaiThuoc.Text = dgvQLT.SelectedRows[0].Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonAnhT_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog path = new OpenFileDialog();
                path.Filter = "JPG Files (*.jpg)|*.jpg|JPG Files (*.png)|*.png|All Files (*.*)|*.*";
                path.Title = "Chọn hình ảnh";
                if (path.ShowDialog() == DialogResult.OK)
                {
                    img = path.FileName.ToString();
                    pbHinhThuoc.ImageLocation = img;
                    MessageBox.Show(path.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Thêm
            try
            {
                if (this.txtTenThuoc.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin Thuốc!", "Thông Báo!");
                    return;
                }

                int a = 0;
                if(txtMaThuoc.Text.Length > 0)
                {
                    a = Int32.Parse(txtMaThuoc.Text);
                }              

                THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == a);

                if (findTHUOC != null)
                {
                    MessageBox.Show("Không được phép nhập trùng tên Thuốc!", "Thông Báo!");
                    return;
                }

                if (findTHUOC == null)
                {
                    findTHUOC = new THUOC();
                    findTHUOC.HINHTHUOC = img;
                    //findTHUOC.MATHUOC = Int32.Parse(txtMaThuoc.Text);
                    findTHUOC.TENTHUOC = txtTenThuoc.Text;
                    findTHUOC.DONGIA = Int32.Parse(txtDG.Text);
                    findTHUOC.DVT = txtDVT.Text;
                    findTHUOC.SOLUONGTON = Int32.Parse(txtSLT.Text);
                    findTHUOC.NGAYSANXUAT = dtpNSX.Value;
                    findTHUOC.HANSUDUNG = dtpHSD.Value;
                    findTHUOC.MOTA = txtMoTa.Text;
                    findTHUOC.MALOAITHUOC = Int32.Parse(cboLoaiThuoc.SelectedValue.ToString());
                    db.THUOCs.Add(findTHUOC);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Thuốc thành công!", "Thông Báo!");
                }
                BindGrid(db.THUOCs.ToList());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //Xóa   
            THUOC findTHUOC = db.THUOCs.FirstOrDefault(p => p.TENTHUOC == txtTenThuoc.Text);
            try
            {            
                if (findTHUOC == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa!", "Thông Báo!");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.THUOCs.Remove(findTHUOC);
                        db.SaveChanges();

                        MessageBox.Show("Xóa Thành Công!");
                    }
                }
                BindGrid(db.THUOCs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Sửa          
            try
            {
                int a = int.Parse(txtMaThuoc.Text);
                THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == a);
                if (findTHUOC != null)
                {
                    string xpathTHUOC = findTHUOC.HINHTHUOC;
                    //findTHUOC.MATHUOC = Int32.Parse(txtMaThuoc.Text);
                    findTHUOC.TENTHUOC = txtTenThuoc.Text;
                    findTHUOC.DVT = txtDVT.Text;
                    findTHUOC.DONGIA = Int32.Parse(txtDG.Text);
                    findTHUOC.SOLUONGTON = Int32.Parse(txtSLT.Text);

                    findTHUOC.NGAYSANXUAT = dtpNSX.Value;
                    findTHUOC.HANSUDUNG = dtpHSD.Value;

                    findTHUOC.MOTA = txtMoTa.Text;
                    findTHUOC.HINHTHUOC = pbHinhThuoc.ImageLocation;
                    findTHUOC.MALOAITHUOC = Int32.Parse(cboLoaiThuoc.SelectedValue.ToString());

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo!");
                }
                BindGrid(db.THUOCs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Lưu

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {        

            this.pbHinhThuoc.ImageLocation = null;
            this.cboLoaiThuoc.Text = "";
            this.txtMaThuoc.Text = "";
            this.txtTenThuoc.Text = "";
            this.txtDG.Text = "";
            this.txtDVT.Text = "";
            this.txtSLT.Text = "";
            this.dtpNSX.Text = "";
            this.dtpHSD.Text = "";
            this.txtMoTa.Text = "";
        }

        private void frmQLThuoc_Load_1(object sender, EventArgs e)
        {
            String sql = "Select * From LOAITHUOC";
            cboLoaiThuoc.DataSource = Database.Singleton.Execute(sql);
            cboLoaiThuoc.ValueMember = "MALOAITHUOC";
            cboLoaiThuoc.DisplayMember = "TENLOAITHUOC";
            BindGrid(db.THUOCs.ToList());
        }

        private void btnChonAnhT_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog path = new OpenFileDialog();
                path.Filter = "JPG Files (*.jpg)|*.jpg|JPG Files (*.png)|*.png|All Files (*.*)|*.*";
                path.Title = "Chọn hình ảnh";
                if (path.ShowDialog() == DialogResult.OK)
                {
                    img = path.FileName.ToString();
                    pbHinhThuoc.ImageLocation = img;
                    MessageBox.Show(path.FileName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtTenThuoc.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin Thuốc!", "Thông Báo!");
                    return;
                }

                int a = 0;
                if (txtMaThuoc.Text.Length > 0)
                {
                    a = Int32.Parse(txtMaThuoc.Text);
                }

                THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == a);

                if (findTHUOC != null)
                {
                    MessageBox.Show("Không được phép nhập trùng tên Thuốc!", "Thông Báo!");
                    return;
                }

                if (findTHUOC == null)
                {
                    findTHUOC = new THUOC();
                    findTHUOC.HINHTHUOC = img;
                    //findTHUOC.MATHUOC = Int32.Parse(txtMaThuoc.Text);
                    findTHUOC.TENTHUOC = txtTenThuoc.Text;
                    findTHUOC.DONGIA = Int32.Parse(txtDG.Text);
                    findTHUOC.DVT = txtDVT.Text;
                    findTHUOC.SOLUONGTON = Int32.Parse(txtSLT.Text);
                    findTHUOC.NGAYSANXUAT = dtpNSX.Value;
                    findTHUOC.HANSUDUNG = dtpHSD.Value;
                    findTHUOC.MOTA = txtMoTa.Text;
                    findTHUOC.MALOAITHUOC = Int32.Parse(cboLoaiThuoc.SelectedValue.ToString());
                    db.THUOCs.Add(findTHUOC);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Thuốc thành công!", "Thông Báo!");
                }
                BindGrid(db.THUOCs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            THUOC findTHUOC = db.THUOCs.FirstOrDefault(p => p.TENTHUOC == txtTenThuoc.Text);
            try
            {
                if (findTHUOC == null)
                {
                    MessageBox.Show("Không tìm thấy đối tượng cần xóa!", "Thông Báo!");
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        db.THUOCs.Remove(findTHUOC);
                        db.SaveChanges();

                        MessageBox.Show("Xóa Thành Công!");

                    }
                }
                BindGrid(db.THUOCs.ToList());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return;
            }
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtMaThuoc.Text);
                THUOC findTHUOC = db.THUOCs.SingleOrDefault(p => p.MATHUOC == a);
                if (findTHUOC != null)
                {
                    string xpathTHUOC = findTHUOC.HINHTHUOC;
                    //findTHUOC.MATHUOC = Int32.Parse(txtMaThuoc.Text);
                    findTHUOC.TENTHUOC = txtTenThuoc.Text;
                    findTHUOC.DVT = txtDVT.Text;
                    findTHUOC.DONGIA = Int32.Parse(txtDG.Text);
                    findTHUOC.SOLUONGTON = Int32.Parse(txtSLT.Text);

                    findTHUOC.NGAYSANXUAT = dtpNSX.Value;
                    findTHUOC.HANSUDUNG = dtpHSD.Value;

                    findTHUOC.MOTA = txtMoTa.Text;
                    findTHUOC.HINHTHUOC = pbHinhThuoc.ImageLocation;
                    findTHUOC.MALOAITHUOC = Int32.Parse(cboLoaiThuoc.SelectedValue.ToString());

                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo!");
                }
                BindGrid(db.THUOCs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshItem_Click(object sender, EventArgs e)
        {
            db = new Model1();
            listThuoc = db.THUOCs.ToList();
            BindGrid(listThuoc);

            this.pbHinhThuoc.ImageLocation = null;
            this.cboLoaiThuoc.Text = "";
            this.txtMaThuoc.Text = "";
            this.txtTenThuoc.Text = "";
            this.txtDG.Text = "";
            this.txtDVT.Text = "";
            this.txtSLT.Text = "";
            this.dtpNSX.Text = "";
            this.dtpHSD.Text = "";
            this.txtMoTa.Text = "";
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void cboLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
