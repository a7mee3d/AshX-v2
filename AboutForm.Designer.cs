namespace AshX
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();

            // Title
            this.lblTitle.Text = "AshX — Multibox Controller";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(360, 30);

            // Version
            this.lblVersion.Text = "Version 2.0";
            this.lblVersion.Location = new System.Drawing.Point(20, 60);
            this.lblVersion.Size = new System.Drawing.Size(200, 25);

            // Developer
            this.lblDeveloper.Text = "Developed by: Ahmed Ashmawy";
            this.lblDeveloper.Location = new System.Drawing.Point(20, 90);
            this.lblDeveloper.Size = new System.Drawing.Size(300, 25);

            // Description
            this.txtDescription.Multiline = true;
            this.txtDescription.ReadOnly = true;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(20, 130);
            this.txtDescription.Size = new System.Drawing.Size(360, 150);
            this.txtDescription.Text =
                "AshX is a modern, safe, and efficient multibox controller for Anarchy Online.\r\n\r\n" +
                "- Clean, modern UI\r\n" +
                "- Safe keyboard mirroring\r\n" +
                "- Custom blocked keys\r\n" +
                "- Delay engine\r\n" +
                "- Persistent settings\r\n\r\n" +
                "Designed for reliability and ease of use.";

            // Close Button
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(140, 300);
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // AboutForm
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnClose);

            this.Text = "About AshX";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
