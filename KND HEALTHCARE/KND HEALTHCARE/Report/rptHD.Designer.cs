namespace KND_HEALTHCARE.Report
{
    partial class rptHD
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
            this.crvHDs = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvHDs
            // 
            this.crvHDs.ActiveViewIndex = -1;
            this.crvHDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHDs.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHDs.Location = new System.Drawing.Point(0, 0);
            this.crvHDs.Name = "crvHDs";
            this.crvHDs.Size = new System.Drawing.Size(800, 450);
            this.crvHDs.TabIndex = 0;
            this.crvHDs.Load += new System.EventHandler(this.crvHDs_Load);
            // 
            // rptHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvHDs);
            this.Name = "rptHD";
            this.Text = "rptHD";
            this.Load += new System.EventHandler(this.rptHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHDs;
    }
}