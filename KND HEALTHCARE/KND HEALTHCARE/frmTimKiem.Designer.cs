namespace KND_HEALTHCARE
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTenThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimLoaiThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.cboFindLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.txtTKtt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTKT = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindTen = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindID = new DevExpress.XtraEditors.SimpleButton();
            this.txtHTnv = new System.Windows.Forms.TextBox();
            this.txtIDnv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTKnv = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NTNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSUDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANSUDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKT)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKnv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 695);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = global::KND_HEALTHCARE.Properties.Resources.frmLogin;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvTKT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1320, 669);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm Kiếm Thuốc";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(286, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 42);
            this.label7.TabIndex = 14;
            this.label7.Text = "TÌM KIẾM THUỐC";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTimTenThuoc);
            this.groupBox2.Controls.Add(this.btnTimLoaiThuoc);
            this.groupBox2.Controls.Add(this.cboFindLoaiThuoc);
            this.groupBox2.Controls.Add(this.txtTKtt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 472);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tìm Kiếm";
            // 
            // btnTimTenThuoc
            // 
            this.btnTimTenThuoc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTenThuoc.Appearance.Options.UseFont = true;
            this.btnTimTenThuoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTimTenThuoc.ImageOptions.SvgImage")));
            this.btnTimTenThuoc.Location = new System.Drawing.Point(89, 336);
            this.btnTimTenThuoc.Name = "btnTimTenThuoc";
            this.btnTimTenThuoc.Size = new System.Drawing.Size(111, 52);
            this.btnTimTenThuoc.TabIndex = 15;
            this.btnTimTenThuoc.Text = "Tìm";
            this.btnTimTenThuoc.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnTimLoaiThuoc
            // 
            this.btnTimLoaiThuoc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLoaiThuoc.Appearance.Options.UseFont = true;
            this.btnTimLoaiThuoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTimLoaiThuoc.ImageOptions.SvgImage")));
            this.btnTimLoaiThuoc.Location = new System.Drawing.Point(89, 164);
            this.btnTimLoaiThuoc.Name = "btnTimLoaiThuoc";
            this.btnTimLoaiThuoc.Size = new System.Drawing.Size(111, 52);
            this.btnTimLoaiThuoc.TabIndex = 14;
            this.btnTimLoaiThuoc.Text = "Tìm";
            this.btnTimLoaiThuoc.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cboFindLoaiThuoc
            // 
            this.cboFindLoaiThuoc.FormattingEnabled = true;
            this.cboFindLoaiThuoc.Location = new System.Drawing.Point(51, 122);
            this.cboFindLoaiThuoc.Name = "cboFindLoaiThuoc";
            this.cboFindLoaiThuoc.Size = new System.Drawing.Size(225, 27);
            this.cboFindLoaiThuoc.TabIndex = 13;
            this.cboFindLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cboFindLoaiThuoc_SelectedIndexChanged);
            // 
            // txtTKtt
            // 
            this.txtTKtt.Location = new System.Drawing.Point(56, 292);
            this.txtTKtt.Name = "txtTKtt";
            this.txtTKtt.Size = new System.Drawing.Size(225, 27);
            this.txtTKtt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhập Tên Thuốc cần tìm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhập Loại Thuốc cần tìm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvTKT
            // 
            this.dgvTKT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKT.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHUOC,
            this.TENTHUOC,
            this.DVT,
            this.DONGIA,
            this.SOLUONGTON,
            this.NGAYSUDUNG,
            this.HANSUDUNG,
            this.MOTA,
            this.HINHTHUOC,
            this.MALOAI});
            this.dgvTKT.Location = new System.Drawing.Point(460, 87);
            this.dgvTKT.Name = "dgvTKT";
            this.dgvTKT.Size = new System.Drawing.Size(857, 461);
            this.dgvTKT.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BackgroundImage = global::KND_HEALTHCARE.Properties.Resources.frmLogin;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dgvTKnv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1320, 669);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm Kiếm Nhân Viên";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(286, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "TÌM KIẾM NHÂN VIÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnFindTen);
            this.groupBox1.Controls.Add(this.btnFindID);
            this.groupBox1.Controls.Add(this.txtHTnv);
            this.groupBox1.Controls.Add(this.txtIDnv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 472);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // btnFindTen
            // 
            this.btnFindTen.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTen.Appearance.Options.UseFont = true;
            this.btnFindTen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFindTen.ImageOptions.SvgImage")));
            this.btnFindTen.Location = new System.Drawing.Point(88, 362);
            this.btnFindTen.Name = "btnFindTen";
            this.btnFindTen.Size = new System.Drawing.Size(111, 52);
            this.btnFindTen.TabIndex = 16;
            this.btnFindTen.Text = "Tìm";
            this.btnFindTen.Click += new System.EventHandler(this.btnFindTen_Click);
            // 
            // btnFindID
            // 
            this.btnFindID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindID.Appearance.Options.UseFont = true;
            this.btnFindID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFindID.ImageOptions.SvgImage")));
            this.btnFindID.Location = new System.Drawing.Point(88, 186);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(111, 52);
            this.btnFindID.TabIndex = 15;
            this.btnFindID.Text = "Tìm";
            this.btnFindID.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // txtHTnv
            // 
            this.txtHTnv.Location = new System.Drawing.Point(64, 304);
            this.txtHTnv.Name = "txtHTnv";
            this.txtHTnv.Size = new System.Drawing.Size(225, 27);
            this.txtHTnv.TabIndex = 3;
            // 
            // txtIDnv
            // 
            this.txtIDnv.Location = new System.Drawing.Point(64, 134);
            this.txtIDnv.Name = "txtIDnv";
            this.txtIDnv.Size = new System.Drawing.Size(225, 27);
            this.txtIDnv.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập Tên cần tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ID cần tìm";
            // 
            // dgvTKnv
            // 
            this.dgvTKnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKnv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTKnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.NTNS,
            this.GIOITINH,
            this.SDT,
            this.CHUCVU});
            this.dgvTKnv.Location = new System.Drawing.Point(498, 76);
            this.dgvTKnv.Name = "dgvTKnv";
            this.dgvTKnv.Size = new System.Drawing.Size(822, 472);
            this.dgvTKnv.TabIndex = 4;
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            // 
            // TENNV
            // 
            this.TENNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNV.HeaderText = "Họ Tên";
            this.TENNV.Name = "TENNV";
            // 
            // NTNS
            // 
            this.NTNS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NTNS.HeaderText = "NTNS";
            this.NTNS.Name = "NTNS";
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // CHUCVU
            // 
            this.CHUCVU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CHUCVU.HeaderText = "Chức Vụ";
            this.CHUCVU.Name = "CHUCVU";
            // 
            // MATHUOC
            // 
            this.MATHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATHUOC.FillWeight = 55.40065F;
            this.MATHUOC.HeaderText = "Mã Thuốc";
            this.MATHUOC.Name = "MATHUOC";
            this.MATHUOC.Visible = false;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENTHUOC.FillWeight = 55.40065F;
            this.TENTHUOC.HeaderText = "Tên Thuốc";
            this.TENTHUOC.Name = "TENTHUOC";
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.FillWeight = 55.40065F;
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DONGIA.FillWeight = 55.40065F;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOLUONGTON.FillWeight = 55.40065F;
            this.SOLUONGTON.HeaderText = "Số Lượng";
            this.SOLUONGTON.Name = "SOLUONGTON";
            // 
            // NGAYSUDUNG
            // 
            this.NGAYSUDUNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSUDUNG.FillWeight = 55.40065F;
            this.NGAYSUDUNG.HeaderText = "Ngày Sản Xuất";
            this.NGAYSUDUNG.Name = "NGAYSUDUNG";
            // 
            // HANSUDUNG
            // 
            this.HANSUDUNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HANSUDUNG.FillWeight = 55.40065F;
            this.HANSUDUNG.HeaderText = "Hạn Sử Dụng";
            this.HANSUDUNG.Name = "HANSUDUNG";
            // 
            // MOTA
            // 
            this.MOTA.HeaderText = "Mô Tả";
            this.MOTA.Name = "MOTA";
            // 
            // HINHTHUOC
            // 
            this.HINHTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HINHTHUOC.FillWeight = 55.40065F;
            this.HINHTHUOC.HeaderText = "Hình Thuốc";
            this.HINHTHUOC.Name = "HINHTHUOC";
            this.HINHTHUOC.Visible = false;
            // 
            // MALOAI
            // 
            this.MALOAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALOAI.FillWeight = 55.40065F;
            this.MALOAI.HeaderText = "Loại";
            this.MALOAI.Name = "MALOAI";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KND_HEALTHCARE.Properties.Resources.frmLogin;
            this.ClientSize = new System.Drawing.Size(1328, 695);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Thông Tin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKT)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTKT;
        private System.Windows.Forms.DataGridView dgvTKnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHTnv;
        private System.Windows.Forms.TextBox txtIDnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTKtt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFindLoaiThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnTimTenThuoc;
        private DevExpress.XtraEditors.SimpleButton btnTimLoaiThuoc;
        private DevExpress.XtraEditors.SimpleButton btnFindTen;
        private DevExpress.XtraEditors.SimpleButton btnFindID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NTNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSUDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANSUDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
    }
}