using System;
using System.Drawing;
using System.Windows.Forms;

namespace AshX
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10F);

            Color softText = Color.FromArgb(200, 200, 200);
            Color accent = Color.FromArgb(0, 229, 255);

            this.ForeColor = softText;

            lblTitle.ForeColor = accent;
            lblVersion.ForeColor = softText;
            lblDeveloper.ForeColor = softText;

            txtDescription.BackColor = Color.FromArgb(37, 37, 38);
            txtDescription.ForeColor = softText;

            btnClose.BackColor = accent;
            btnClose.FlatStyle = FlatStyle.Flat;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
