namespace KND_HEALTHCARE.Report
{
    partial class rptThuoc
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
            this.crvThuocs = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvThuocs
            // 
            this.crvThuocs.ActiveViewIndex = -1;
            this.crvThuocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvThuocs.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvThuocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvThuocs.Location = new System.Drawing.Point(0, 0);
            this.crvThuocs.Name = "crvThuocs";
            this.crvThuocs.Size = new System.Drawing.Size(800, 450);
            this.crvThuocs.TabIndex = 0;
            // 
            // rptThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvThuocs);
            this.Name = "rptThuoc";
            this.Text = "rptThuoc";
            this.Load += new System.EventHandler(this.rptThuoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvThuocs;
    }
}