namespace KND_HEALTHCARE
{
    partial class frmQLTK
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXNT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTPass = new System.Windows.Forms.TextBox();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.btnXNX = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNLID = new System.Windows.Forms.TextBox();
            this.txtXID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBackNVT = new System.Windows.Forms.Button();
            this.btnBackNVX = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBackNVT);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnXNT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTPass);
            this.tabPage1.Controls.Add(this.txtTID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBackNVX);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnXNX);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNLID);
            this.tabPage2.Controls.Add(this.txtXID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xóa Tài Khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXNT
            // 
            this.btnXNT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXNT.Location = new System.Drawing.Point(179, 236);
            this.btnXNT.Name = "btnXNT";
            this.btnXNT.Size = new System.Drawing.Size(89, 27);
            this.btnXNT.TabIndex = 17;
            this.btnXNT.Text = "Xác Nhận";
            this.btnXNT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhập ID";
            // 
            // txtTPass
            // 
            this.txtTPass.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPass.Location = new System.Drawing.Point(127, 178);
            this.txtTPass.Name = "txtTPass";
            this.txtTPass.Size = new System.Drawing.Size(197, 27);
            this.txtTPass.TabIndex = 14;
            this.txtTPass.TextChanged += new System.EventHandler(this.txtTPass_TextChanged);
            // 
            // txtTID
            // 
            this.txtTID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTID.Location = new System.Drawing.Point(128, 106);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(196, 27);
            this.txtTID.TabIndex = 13;
            // 
            // btnXNX
            // 
            this.btnXNX.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXNX.Location = new System.Drawing.Point(179, 236);
            this.btnXNX.Name = "btnXNX";
            this.btnXNX.Size = new System.Drawing.Size(89, 27);
            this.btnXNX.TabIndex = 17;
            this.btnXNX.Text = "Xác Nhận";
            this.btnXNX.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhập lại ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhập ID";
            // 
            // txtNLID
            // 
            this.txtNLID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLID.Location = new System.Drawing.Point(127, 178);
            this.txtNLID.Name = "txtNLID";
            this.txtNLID.Size = new System.Drawing.Size(197, 27);
            this.txtNLID.TabIndex = 14;
            // 
            // txtXID
            // 
            this.txtXID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXID.Location = new System.Drawing.Point(128, 106);
            this.txtXID.Name = "txtXID";
            this.txtXID.Size = new System.Drawing.Size(196, 27);
            this.txtXID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "XÓA TÀI KHOẢN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "TẠO TÀI KHOẢN";
            // 
            // btnBackNVT
            // 
            this.btnBackNVT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNVT.Location = new System.Drawing.Point(140, 288);
            this.btnBackNVT.Name = "btnBackNVT";
            this.btnBackNVT.Size = new System.Drawing.Size(169, 27);
            this.btnBackNVT.TabIndex = 20;
            this.btnBackNVT.Text = "Quay Về Nhân Viên";
            this.btnBackNVT.UseVisualStyleBackColor = true;
            // 
            // btnBackNVX
            // 
            this.btnBackNVX.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNVX.Location = new System.Drawing.Point(140, 288);
            this.btnBackNVX.Name = "btnBackNVX";
            this.btnBackNVX.Size = new System.Drawing.Size(169, 27);
            this.btnBackNVX.TabIndex = 19;
            this.btnBackNVX.Text = "Quay Về Nhân Viên";
            this.btnBackNVX.UseVisualStyleBackColor = true;
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 371);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmQLTK";
            this.Text = "Quản Lý Tài Khoản";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnXNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTPass;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.Button btnXNX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNLID;
        private System.Windows.Forms.TextBox txtXID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackNVT;
        private System.Windows.Forms.Button btnBackNVX;
    }
}