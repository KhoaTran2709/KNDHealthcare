namespace KND_HEALTHCARE
{
    partial class frmQLThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLThuoc));
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChonAnhT = new System.Windows.Forms.Button();
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.pbHinhThuoc = new System.Windows.Forms.PictureBox();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLT = new System.Windows.Forms.DataGridView();
            this.MATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSANXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANSUDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAITHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MenuQLThuoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.MenuQLThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(17, 600);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 26);
            this.label11.TabIndex = 27;
            this.label11.Text = "Mô Tả:";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(144, 283);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(163, 27);
            this.txtMaThuoc.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(324, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Loại:";
            // 
            // btnChonAnhT
            // 
            this.btnChonAnhT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnhT.Location = new System.Drawing.Point(25, 81);
            this.btnChonAnhT.Name = "btnChonAnhT";
            this.btnChonAnhT.Size = new System.Drawing.Size(75, 27);
            this.btnChonAnhT.TabIndex = 19;
            this.btnChonAnhT.Text = "Chọn";
            this.btnChonAnhT.UseVisualStyleBackColor = true;
            this.btnChonAnhT.Click += new System.EventHandler(this.btnChonAnhT_Click_1);
            // 
            // txtSLT
            // 
            this.txtSLT.Location = new System.Drawing.Point(144, 466);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(111, 27);
            this.txtSLT.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "SL Tồn:";
            // 
            // dtpNSX
            // 
            this.dtpNSX.CustomFormat = "dd/MM/yyyy";
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNSX.Location = new System.Drawing.Point(144, 511);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(256, 27);
            this.dtpNSX.TabIndex = 11;
            this.dtpNSX.Value = new System.DateTime(2021, 11, 12, 12, 14, 29, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "HSD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hình Ảnh";
            // 
            // dtpHSD
            // 
            this.dtpHSD.CustomFormat = "dd/MM/yyyy";
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHSD.Location = new System.Drawing.Point(144, 554);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(256, 27);
            this.dtpHSD.TabIndex = 12;
            // 
            // pbHinhThuoc
            // 
            this.pbHinhThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHinhThuoc.Image = global::KND_HEALTHCARE.Properties.Resources.note;
            this.pbHinhThuoc.Location = new System.Drawing.Point(119, 43);
            this.pbHinhThuoc.Name = "pbHinhThuoc";
            this.pbHinhThuoc.Size = new System.Drawing.Size(333, 215);
            this.pbHinhThuoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinhThuoc.TabIndex = 18;
            this.pbHinhThuoc.TabStop = false;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(144, 328);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(266, 27);
            this.txtTenThuoc.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Đơn Giá:";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(144, 373);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(111, 27);
            this.txtDVT.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "NSX:";
            // 
            // dgvQLT
            // 
            this.dgvQLT.AllowUserToAddRows = false;
            this.dgvQLT.AllowUserToDeleteRows = false;
            this.dgvQLT.AllowUserToResizeColumns = false;
            this.dgvQLT.AllowUserToResizeRows = false;
            this.dgvQLT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLT.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQLT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHUOC,
            this.TENTHUOC,
            this.DVT,
            this.DONGIA,
            this.SOLUONGTON,
            this.NGAYSANXUAT,
            this.HANSUDUNG,
            this.HINHTHUOC,
            this.MOTA,
            this.TENLOAITHUOC});
            this.dgvQLT.Location = new System.Drawing.Point(560, 62);
            this.dgvQLT.Name = "dgvQLT";
            this.dgvQLT.ReadOnly = true;
            this.dgvQLT.Size = new System.Drawing.Size(828, 409);
            this.dgvQLT.TabIndex = 14;
            this.dgvQLT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLT_CellClick);
            this.dgvQLT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLT_CellClick);
            // 
            // MATHUOC
            // 
            this.MATHUOC.FillWeight = 18.78782F;
            this.MATHUOC.HeaderText = "Mã Thuốc";
            this.MATHUOC.MinimumWidth = 7;
            this.MATHUOC.Name = "MATHUOC";
            this.MATHUOC.ReadOnly = true;
            this.MATHUOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MATHUOC.Visible = false;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENTHUOC.FillWeight = 26.62225F;
            this.TENTHUOC.HeaderText = "Tên Thuốc";
            this.TENTHUOC.Name = "TENTHUOC";
            this.TENTHUOC.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.FillWeight = 18.78782F;
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DONGIA.FillWeight = 23F;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOLUONGTON.FillWeight = 23F;
            this.SOLUONGTON.HeaderText = "Tồn Kho";
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.ReadOnly = true;
            // 
            // NGAYSANXUAT
            // 
            this.NGAYSANXUAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSANXUAT.FillWeight = 30F;
            this.NGAYSANXUAT.HeaderText = "Ngày Sản Xuất";
            this.NGAYSANXUAT.Name = "NGAYSANXUAT";
            this.NGAYSANXUAT.ReadOnly = true;
            // 
            // HANSUDUNG
            // 
            this.HANSUDUNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HANSUDUNG.FillWeight = 30F;
            this.HANSUDUNG.HeaderText = "Hạn Sử Dụng";
            this.HANSUDUNG.Name = "HANSUDUNG";
            this.HANSUDUNG.ReadOnly = true;
            // 
            // HINHTHUOC
            // 
            this.HINHTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HINHTHUOC.FillWeight = 18F;
            this.HINHTHUOC.HeaderText = "Hình Thuốc";
            this.HINHTHUOC.Name = "HINHTHUOC";
            this.HINHTHUOC.ReadOnly = true;
            this.HINHTHUOC.Visible = false;
            // 
            // MOTA
            // 
            this.MOTA.FillWeight = 50F;
            this.MOTA.HeaderText = "Mô Tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            // 
            // TENLOAITHUOC
            // 
            this.TENLOAITHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLOAITHUOC.FillWeight = 30F;
            this.TENLOAITHUOC.HeaderText = "Loại Thuốc";
            this.TENLOAITHUOC.Name = "TENLOAITHUOC";
            this.TENLOAITHUOC.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "DVT:";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(144, 420);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(111, 27);
            this.txtDG.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thuốc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboLoaiThuoc);
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMaThuoc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnChonAnhT);
            this.groupBox1.Controls.Add(this.txtSLT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNSX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpHSD);
            this.groupBox1.Controls.Add(this.pbHinhThuoc);
            this.groupBox1.Controls.Add(this.txtTenThuoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 669);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Thuốc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cboLoaiThuoc
            // 
            this.cboLoaiThuoc.FormattingEnabled = true;
            this.cboLoaiThuoc.Location = new System.Drawing.Point(397, 284);
            this.cboLoaiThuoc.Name = "cboLoaiThuoc";
            this.cboLoaiThuoc.Size = new System.Drawing.Size(143, 27);
            this.cboLoaiThuoc.TabIndex = 28;
            this.cboLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThuoc_SelectedIndexChanged);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(144, 587);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(396, 76);
            this.txtMoTa.TabIndex = 15;
            this.txtMoTa.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(298, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(554, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "QUẢN LÝ THÔNG TIN THUỐC";
            // 
            // MenuQLThuoc
            // 
            this.MenuQLThuoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItem,
            this.DeleteItem,
            this.EditItem,
            this.RefreshItem});
            this.MenuQLThuoc.Name = "MenuQLNV";
            this.MenuQLThuoc.Size = new System.Drawing.Size(114, 92);
            this.MenuQLThuoc.Text = "asd";
            // 
            // AddItem
            // 
            this.AddItem.Image = global::KND_HEALTHCARE.Properties.Resources.add;
            this.AddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(113, 22);
            this.AddItem.Text = "Thêm";
            this.AddItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Image = global::KND_HEALTHCARE.Properties.Resources.subtraction_symbol;
            this.DeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(113, 22);
            this.DeleteItem.Text = "Xóa";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.Image = global::KND_HEALTHCARE.Properties.Resources.edit;
            this.EditItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(113, 22);
            this.EditItem.Text = "Sửa";
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // RefreshItem
            // 
            this.RefreshItem.Image = global::KND_HEALTHCARE.Properties.Resources.refresh;
            this.RefreshItem.Name = "RefreshItem";
            this.RefreshItem.Size = new System.Drawing.Size(113, 22);
            this.RefreshItem.Text = "Refresh";
            this.RefreshItem.Click += new System.EventHandler(this.RefreshItem_Click);
            // 
            // frmQLThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KND_HEALTHCARE.Properties.Resources.frmLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1389, 735);
            this.ContextMenuStrip = this.MenuQLThuoc;
            this.Controls.Add(this.dgvQLT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLThuoc";
            this.Text = "Quản Lý Thông Tin Thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLThuoc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuQLThuoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChonAnhT;
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.PictureBox pbHinhThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQLT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSANXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANSUDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAITHUOC;
        private System.Windows.Forms.ContextMenuStrip MenuQLThuoc;
        private System.Windows.Forms.ToolStripMenuItem AddItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem EditItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshItem;
        private System.Windows.Forms.RichTextBox txtMoTa;
    }
}