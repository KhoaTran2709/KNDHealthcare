namespace KND_HEALTHCARE.Report
{
    partial class rptThuocHuy
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
            this.crvThuocHuys = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvThuocHuys
            // 
            this.crvThuocHuys.ActiveViewIndex = -1;
            this.crvThuocHuys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvThuocHuys.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvThuocHuys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvThuocHuys.Location = new System.Drawing.Point(0, 0);
            this.crvThuocHuys.Name = "crvThuocHuys";
            this.crvThuocHuys.Size = new System.Drawing.Size(800, 450);
            this.crvThuocHuys.TabIndex = 0;
            // 
            // rptThuocHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvThuocHuys);
            this.Name = "rptThuocHuy";
            this.Text = "rptThuocHuy";
            this.Load += new System.EventHandler(this.rptThuocHuy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvThuocHuys;
    }
}