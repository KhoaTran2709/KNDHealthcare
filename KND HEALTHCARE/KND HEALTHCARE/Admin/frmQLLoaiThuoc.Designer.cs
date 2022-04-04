namespace KND_HEALTHCARE
{
    partial class frmQLLoaiThuoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLoaiThuoc));
            this.dgv_LoaiThuoc = new System.Windows.Forms.DataGridView();
            this.MALOAITHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAITHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaKho = new System.Windows.Forms.ComboBox();
            this.txtTenLoaiThuoc = new System.Windows.Forms.TextBox();
            this.btnXoaNV = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.MenuQLLoaiThuoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.btnXoaNV.SuspendLayout();
            this.MenuQLLoaiThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LoaiThuoc
            // 
            this.dgv_LoaiThuoc.AllowUserToDeleteRows = false;
            this.dgv_LoaiThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LoaiThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiThuoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_LoaiThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAITHUOC,
            this.TENLOAITHUOC,
            this.GHICHU,
            this.MAKHO});
            this.dgv_LoaiThuoc.Location = new System.Drawing.Point(1, 98);
            this.dgv_LoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_LoaiThuoc.Name = "dgv_LoaiThuoc";
            this.dgv_LoaiThuoc.ReadOnly = true;
            this.dgv_LoaiThuoc.Size = new System.Drawing.Size(929, 173);
            this.dgv_LoaiThuoc.TabIndex = 0;
            this.dgv_LoaiThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiThuoc_CellContentClick);
            this.dgv_LoaiThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiThuoc_CellContentClick);
            // 
            // MALOAITHUOC
            // 
            this.MALOAITHUOC.FillWeight = 75F;
            this.MALOAITHUOC.HeaderText = "Mã Loại Thuốc";
            this.MALOAITHUOC.Name = "MALOAITHUOC";
            this.MALOAITHUOC.ReadOnly = true;
            this.MALOAITHUOC.Visible = false;
            // 
            // TENLOAITHUOC
            // 
            this.TENLOAITHUOC.HeaderText = "Tên Loại Thuốc";
            this.TENLOAITHUOC.Name = "TENLOAITHUOC";
            this.TENLOAITHUOC.ReadOnly = true;
            // 
            // GHICHU
            // 
            this.GHICHU.HeaderText = "Ghi Chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            // 
            // MAKHO
            // 
            this.MAKHO.FillWeight = 50F;
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(286, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = "QUẢN LÍ LOẠI THUỐC";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMaLoaiThuoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnHienThi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMaKho);
            this.groupBox1.Controls.Add(this.txtTenLoaiThuoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 237);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtMaLoaiThuoc
            // 
            this.txtMaLoaiThuoc.Enabled = false;
            this.txtMaLoaiThuoc.Location = new System.Drawing.Point(215, 78);
            this.txtMaLoaiThuoc.Name = "txtMaLoaiThuoc";
            this.txtMaLoaiThuoc.ReadOnly = true;
            this.txtMaLoaiThuoc.Size = new System.Drawing.Size(100, 26);
            this.txtMaLoaiThuoc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Loại:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(462, 36);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(100, 32);
            this.btnHienThi.TabIndex = 19;
            this.btnHienThi.Text = "Xem";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(215, 157);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(347, 62);
            this.txtGhiChu.TabIndex = 17;
            this.txtGhiChu.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Loại Thuốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã Kho:";
            // 
            // cboMaKho
            // 
            this.cboMaKho.Enabled = false;
            this.cboMaKho.FormattingEnabled = true;
            this.cboMaKho.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cboMaKho.Location = new System.Drawing.Point(215, 36);
            this.cboMaKho.Name = "cboMaKho";
            this.cboMaKho.Size = new System.Drawing.Size(189, 28);
            this.cboMaKho.TabIndex = 14;
            this.cboMaKho.SelectedIndexChanged += new System.EventHandler(this.cboMaKho_SelectedIndexChanged_1);
            // 
            // txtTenLoaiThuoc
            // 
            this.txtTenLoaiThuoc.Location = new System.Drawing.Point(215, 109);
            this.txtTenLoaiThuoc.Name = "txtTenLoaiThuoc";
            this.txtTenLoaiThuoc.ReadOnly = true;
            this.txtTenLoaiThuoc.Size = new System.Drawing.Size(189, 26);
            this.txtTenLoaiThuoc.TabIndex = 13;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaNV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaNV.Controls.Add(this.btnSua);
            this.btnXoaNV.Controls.Add(this.btnXoa);
            this.btnXoaNV.Controls.Add(this.btnThem);
            this.btnXoaNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(741, 304);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(179, 237);
            this.btnXoaNV.TabIndex = 20;
            this.btnXoaNV.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(23, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 44);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Update";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(23, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 44);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(23, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 45);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Add";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MenuQLLoaiThuoc
            // 
            this.MenuQLLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQLLoaiThuoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.EditMenuItem,
            this.refreshToolStripMenuItem});
            this.MenuQLLoaiThuoc.Name = "MenuQLNV";
            this.MenuQLLoaiThuoc.Size = new System.Drawing.Size(138, 82);
            this.MenuQLLoaiThuoc.Text = "asd";
            this.MenuQLLoaiThuoc.Opening += new System.ComponentModel.CancelEventHandler(this.MenuQLLoaiThuoc_Opening);
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(137, 26);
            this.AddMenuItem.Text = "Thêm";
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(137, 26);
            this.EditMenuItem.Text = "Sửa";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // frmQLLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KND_HEALTHCARE.Properties.Resources.frmLogin1;
            this.ClientSize = new System.Drawing.Size(932, 557);
            this.ContextMenuStrip = this.MenuQLLoaiThuoc;
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_LoaiThuoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLLoaiThuoc";
            this.Text = "Quản Lí Loại Thuốc";
            this.Load += new System.EventHandler(this.frmQLLoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnXoaNV.ResumeLayout(false);
            this.MenuQLLoaiThuoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaKho;
        private System.Windows.Forms.TextBox txtTenLoaiThuoc;
        private System.Windows.Forms.GroupBox btnXoaNV;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtMaLoaiThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip MenuQLLoaiThuoc;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAITHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAITHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKHO;
    }
}