namespace KND_HEALTHCARE.Report
{
    partial class rptNhanVien
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
            this.crvNhanViens = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvNhanViens
            // 
            this.crvNhanViens.ActiveViewIndex = -1;
            this.crvNhanViens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhanViens.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNhanViens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNhanViens.Location = new System.Drawing.Point(0, 0);
            this.crvNhanViens.Name = "crvNhanViens";
            this.crvNhanViens.Size = new System.Drawing.Size(800, 450);
            this.crvNhanViens.TabIndex = 0;
            // 
            // rptNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvNhanViens);
            this.Name = "rptNhanVien";
            this.Text = "rptNhanVien";
            this.Load += new System.EventHandler(this.rptNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhanViens;
    }
}