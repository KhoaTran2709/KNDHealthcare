namespace KND_HEALTHCARE.Report
{
    partial class rptNCC
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
            this.crvNCCs = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvNCCs
            // 
            this.crvNCCs.ActiveViewIndex = -1;
            this.crvNCCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNCCs.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNCCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNCCs.Location = new System.Drawing.Point(0, 0);
            this.crvNCCs.Name = "crvNCCs";
            this.crvNCCs.Size = new System.Drawing.Size(800, 450);
            this.crvNCCs.TabIndex = 0;
            // 
            // rptNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvNCCs);
            this.Name = "rptNCC";
            this.Text = "rptNCC";
            this.Load += new System.EventHandler(this.rptNCC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNCCs;
    }
}