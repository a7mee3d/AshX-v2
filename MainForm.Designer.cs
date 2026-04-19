namespace AshX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // ============================
        // Characters
        // ============================
        private System.Windows.Forms.GroupBox grpCharacters;
        private System.Windows.Forms.ComboBox cmbMain;
        private System.Windows.Forms.ComboBox cmbSecond;
        private System.Windows.Forms.Button btnSetMain;
        private System.Windows.Forms.Button btnSetSecond;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblSecond;

        // ============================
        // Options
        // ============================
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkEnableMirroring;
        private System.Windows.Forms.CheckBox chkEnableDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numDelayMs;
        private System.Windows.Forms.CheckBox chkBlockChat;

        // Helper labels
        private System.Windows.Forms.Label lblMirroringInfo;
        private System.Windows.Forms.Label lblDelayInfo;

        // ============================
        // Blocked Keys
        // ============================
        private System.Windows.Forms.GroupBox grpBlockedKeys;
        private System.Windows.Forms.ListBox lstBlockedKeys;
        private System.Windows.Forms.TextBox txtAddKey;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Button btnRemoveKey;

        // ============================
        // Tools
        // ============================
        private System.Windows.Forms.GroupBox grpTools;
        private System.Windows.Forms.Button btnRefreshWindows;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.TextBox txtHotkeyToggle;

        // ============================
        // Advanced Settings
        // ============================
        private System.Windows.Forms.GroupBox grpAdvanced;
        private System.Windows.Forms.Label lblAdvDelayMs;
        private System.Windows.Forms.NumericUpDown numAdvDelayMs;
        private System.Windows.Forms.CheckBox chkAdvAutoStart;
        private System.Windows.Forms.CheckBox chkAdvAutoLoadWindows;
        private System.Windows.Forms.CheckBox chkAdvAutoEnableMirroring;

        // ============================
        // Start / Stop / Status
        // ============================
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;

        // ============================
        // About Button
        // ============================
        private System.Windows.Forms.Button btnAbout;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            System.Drawing.Color textColor = System.Drawing.Color.White;
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(0, 229, 255);

            // ============================================================
            // MainForm
            // ============================================================
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "AshX — Multibox Controller";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.DoubleBuffered = true;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            // ============================================================
            // About Button (Top‑Right)
            // ============================================================
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnAbout.Text = "About";
            this.btnAbout.Location = new System.Drawing.Point(720, 10);
            this.btnAbout.Size = new System.Drawing.Size(60, 28);
            this.btnAbout.BackColor = accent;
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Click += (s, e) => new AboutForm().ShowDialog();

            // ============================================================
            // grpCharacters
            // ============================================================
            this.grpCharacters = new System.Windows.Forms.GroupBox();
            this.grpCharacters.Text = "Characters";
            this.grpCharacters.ForeColor = textColor;
            this.grpCharacters.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.grpCharacters.Location = new System.Drawing.Point(20, 20);
            this.grpCharacters.Size = new System.Drawing.Size(350, 160);

            this.lblMain = new System.Windows.Forms.Label();
            this.lblMain.Text = "Main Window:";
            this.lblMain.ForeColor = textColor;
            this.lblMain.Location = new System.Drawing.Point(15, 35);

            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.cmbMain.Location = new System.Drawing.Point(140, 32);
            this.cmbMain.Size = new System.Drawing.Size(180, 25);
            this.cmbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnSetMain = new System.Windows.Forms.Button();
            this.btnSetMain.Text = "Set Main";
            this.btnSetMain.Location = new System.Drawing.Point(140, 65);
            this.btnSetMain.Size = new System.Drawing.Size(180, 30);
            this.btnSetMain.BackColor = accent;
            this.btnSetMain.ForeColor = System.Drawing.Color.Black;
            this.btnSetMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMain.Click += new System.EventHandler(this.btnSetMain_Click);

            this.lblSecond = new System.Windows.Forms.Label();
            this.lblSecond.Text = "Second Window:";
            this.lblSecond.ForeColor = textColor;
            this.lblSecond.Location = new System.Drawing.Point(15, 105);

            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.cmbSecond.Location = new System.Drawing.Point(140, 102);
            this.cmbSecond.Size = new System.Drawing.Size(180, 25);
            this.cmbSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnSetSecond = new System.Windows.Forms.Button();
            this.btnSetSecond.Text = "Set Second";
            this.btnSetSecond.Location = new System.Drawing.Point(140, 135);
            this.btnSetSecond.Size = new System.Drawing.Size(180, 30);
            this.btnSetSecond.BackColor = accent;
            this.btnSetSecond.ForeColor = System.Drawing.Color.Black;
            this.btnSetSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSecond.Click += new System.EventHandler(this.btnSetSecond_Click);

            this.grpCharacters.Controls.Add(this.lblMain);
            this.grpCharacters.Controls.Add(this.cmbMain);
            this.grpCharacters.Controls.Add(this.btnSetMain);
            this.grpCharacters.Controls.Add(this.lblSecond);
            this.grpCharacters.Controls.Add(this.cmbSecond);
            this.grpCharacters.Controls.Add(this.btnSetSecond);

            // ============================================================
            // grpOptions
            // ============================================================
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpOptions.Text = "Options";
            this.grpOptions.ForeColor = textColor;
            this.grpOptions.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.grpOptions.Location = new System.Drawing.Point(20, 200);
            this.grpOptions.Size = new System.Drawing.Size(350, 200);

            this.chkEnableMirroring = new System.Windows.Forms.CheckBox();
            this.chkEnableMirroring.Text = "Enable Mirroring";
            this.chkEnableMirroring.ForeColor = textColor;
            this.chkEnableMirroring.Location = new System.Drawing.Point(15, 30);

            this.lblMirroringInfo = new System.Windows.Forms.Label();
            this.lblMirroringInfo.Text = "(Copies keys to other windows)";
            this.lblMirroringInfo.ForeColor = textColor;
            this.lblMirroringInfo.Location = new System.Drawing.Point(35, 50);
            this.lblMirroringInfo.Size = new System.Drawing.Size(260, 20);

            this.chkEnableDelay = new System.Windows.Forms.CheckBox();
            this.chkEnableDelay.Text = "Enable Delay";
            this.chkEnableDelay.ForeColor = textColor;
            this.chkEnableDelay.Location = new System.Drawing.Point(15, 80);

            this.lblDelayInfo = new System.Windows.Forms.Label();
            this.lblDelayInfo.Text = "(Adds delay between keys)";
            this.lblDelayInfo.ForeColor = textColor;
            this.lblDelayInfo.Location = new System.Drawing.Point(35, 100);
            this.lblDelayInfo.Size = new System.Drawing.Size(260, 20);

            this.lblDelay = new System.Windows.Forms.Label();
            this.lblDelay.Text = "Delay (seconds):";
            this.lblDelay.ForeColor = textColor;
            this.lblDelay.Location = new System.Drawing.Point(15, 130);

            this.numDelayMs = new System.Windows.Forms.NumericUpDown();
            this.numDelayMs.Location = new System.Drawing.Point(160, 130);
            this.numDelayMs.Maximum = 10;
            this.numDelayMs.DecimalPlaces = 1;
            this.numDelayMs.Increment = 0.1M;
            this.numDelayMs.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.numDelayMs.ForeColor = textColor;

            this.chkBlockChat = new System.Windows.Forms.CheckBox();
            this.chkBlockChat.Text = "Block Chat (Enter pauses mirroring)";
            this.chkBlockChat.ForeColor = textColor;
            this.chkBlockChat.Location = new System.Drawing.Point(15, 160);

            this.grpOptions.Controls.Add(this.chkEnableMirroring);
            this.grpOptions.Controls.Add(this.lblMirroringInfo);
            this.grpOptions.Controls.Add(this.chkEnableDelay);
            this.grpOptions.Controls.Add(this.lblDelayInfo);
            this.grpOptions.Controls.Add(this.lblDelay);
            this.grpOptions.Controls.Add(this.numDelayMs);
            this.grpOptions.Controls.Add(this.chkBlockChat);

            // ============================================================
            // grpBlockedKeys
            // ============================================================
            this.grpBlockedKeys = new System.Windows.Forms.GroupBox();
            this.grpBlockedKeys.Text = "Blocked Keys";
            this.grpBlockedKeys.ForeColor = textColor;
            this.grpBlockedKeys.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.grpBlockedKeys.Location = new System.Drawing.Point(400, 20);
            this.grpBlockedKeys.Size = new System.Drawing.Size(370, 360);

            this.lstBlockedKeys = new System.Windows.Forms.ListBox();
            this.lstBlockedKeys.Location = new System.Drawing.Point(15, 30);
            this.lstBlockedKeys.Size = new System.Drawing.Size(340, 230);
            this.lstBlockedKeys.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.lstBlockedKeys.ForeColor = textColor;

            this.txtAddKey = new System.Windows.Forms.TextBox();
            this.txtAddKey.Location = new System.Drawing.Point(15, 270);
            this.txtAddKey.Size = new System.Drawing.Size(200, 25);
            this.txtAddKey.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.txtAddKey.ForeColor = textColor;

            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnAddKey.Text = "Add";
            this.btnAddKey.Location = new System.Drawing.Point(230, 268);
            this.btnAddKey.Size = new System.Drawing.Size(60, 28);
            this.btnAddKey.BackColor = accent;
            this.btnAddKey.ForeColor = System.Drawing.Color.Black;
            this.btnAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);

            this.btnRemoveKey = new System.Windows.Forms.Button();
            this.btnRemoveKey.Text = "Remove";
            this.btnRemoveKey.Location = new System.Drawing.Point(300, 268);
            this.btnRemoveKey.Size = new System.Drawing.Size(60, 28);
            this.btnRemoveKey.BackColor = accent;
            this.btnRemoveKey.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveKey.Click += new System.EventHandler(this.btnRemoveKey_Click);

            this.grpBlockedKeys.Controls.Add(this.lstBlockedKeys);
            this.grpBlockedKeys.Controls.Add(this.txtAddKey);
            this.grpBlockedKeys.Controls.Add(this.btnAddKey);
            this.grpBlockedKeys.Controls.Add(this.btnRemoveKey);

            // ============================================================
            // grpTools
            // ============================================================
            this.grpTools = new System.Windows.Forms.GroupBox();
            this.grpTools.Text = "Tools";
            this.grpTools.ForeColor = textColor;
            this.grpTools.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.grpTools.Location = new System.Drawing.Point(20, 400);
            this.grpTools.Size = new System.Drawing.Size(350, 160);

            this.btnRefreshWindows = new System.Windows.Forms.Button();
            this.btnRefreshWindows.Text = "Refresh Windows";
            this.btnRefreshWindows.Location = new System.Drawing.Point(15, 30);
            this.btnRefreshWindows.Size = new System.Drawing.Size(300, 35);
            this.btnRefreshWindows.BackColor = accent;
            this.btnRefreshWindows.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshWindows.Click += (s, e) => RefreshWindowList();

            this.lblHotkey = new System.Windows.Forms.Label();
            this.lblHotkey.Text = "Hotkey to Toggle Mirroring:";
            this.lblHotkey.ForeColor = textColor;
            this.lblHotkey.Location = new System.Drawing.Point(15, 80);

            this.txtHotkeyToggle = new System.Windows.Forms.TextBox();
            this.txtHotkeyToggle.Location = new System.Drawing.Point(15, 110);
            this.txtHotkeyToggle.Size = new System.Drawing.Size(300, 25);
            this.txtHotkeyToggle.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.txtHotkeyToggle.ForeColor = textColor;
            this.txtHotkeyToggle.Text = "F12";

            this.grpTools.Controls.Add(this.btnRefreshWindows);
            this.grpTools.Controls.Add(this.lblHotkey);
            this.grpTools.Controls.Add(this.txtHotkeyToggle);

            // ============================================================
            // grpAdvanced
            // ============================================================
            this.grpAdvanced = new System.Windows.Forms.GroupBox();
            this.grpAdvanced.Text = "Advanced Settings";
            this.grpAdvanced.ForeColor = textColor;
            this.grpAdvanced.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.grpAdvanced.Location = new System.Drawing.Point(400, 400);
            this.grpAdvanced.Size = new System.Drawing.Size(370, 160);

            this.lblAdvDelayMs = new System.Windows.Forms.Label();
            this.lblAdvDelayMs.Text = "Delay (ms):";
            this.lblAdvDelayMs.ForeColor = textColor;
            this.lblAdvDelayMs.Location = new System.Drawing.Point(15, 35);

            this.numAdvDelayMs = new System.Windows.Forms.NumericUpDown();
            this.numAdvDelayMs.Location = new System.Drawing.Point(150, 35);
            this.numAdvDelayMs.Size = new System.Drawing.Size(80, 25);
            this.numAdvDelayMs.Maximum = 5000;
            this.numAdvDelayMs.Increment = 50;
            this.numAdvDelayMs.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.numAdvDelayMs.ForeColor = textColor;

            this.chkAdvAutoStart = new System.Windows.Forms.CheckBox();
            this.chkAdvAutoStart.Text = "Auto-start Mirroring";
            this.chkAdvAutoStart.ForeColor = textColor;
            this.chkAdvAutoStart.Location = new System.Drawing.Point(15, 75);

            this.chkAdvAutoLoadWindows = new System.Windows.Forms.CheckBox();
            this.chkAdvAutoLoadWindows.Text = "Auto-load Last Windows";
            this.chkAdvAutoLoadWindows.ForeColor = textColor;
            this.chkAdvAutoLoadWindows.Location = new System.Drawing.Point(15, 105);

            this.chkAdvAutoEnableMirroring = new System.Windows.Forms.CheckBox();
            this.chkAdvAutoEnableMirroring.Text = "Auto-enable Mirroring";
            this.chkAdvAutoEnableMirroring.ForeColor = textColor;
            this.chkAdvAutoEnableMirroring.Location = new System.Drawing.Point(15, 135);

            this.grpAdvanced.Controls.Add(this.lblAdvDelayMs);
            this.grpAdvanced.Controls.Add(this.numAdvDelayMs);
            this.grpAdvanced.Controls.Add(this.chkAdvAutoStart);
            this.grpAdvanced.Controls.Add(this.chkAdvAutoLoadWindows);
            this.grpAdvanced.Controls.Add(this.chkAdvAutoEnableMirroring);

            // ============================================================
            // Start / Stop / Status
            // ============================================================
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStart.Text = "Start";
            this.btnStart.Location = new System.Drawing.Point(20, 570);
            this.btnStart.Size = new System.Drawing.Size(150, 30);
            this.btnStart.BackColor = accent;
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.btnStop = new System.Windows.Forms.Button();
            this.btnStop.Text = "Stop";
            this.btnStop.Location = new System.Drawing.Point(190, 570);
            this.btnStop.Size = new System.Drawing.Size(150, 30);
            this.btnStop.BackColor = accent;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatus.Text = "Status: Idle";
            this.lblStatus.ForeColor = textColor;
            this.lblStatus.Location = new System.Drawing.Point(400, 570);
            this.lblStatus.Size = new System.Drawing.Size(350, 30);

            // ============================================================
            // Add Controls to Form
            // ============================================================
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpCharacters);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpBlockedKeys);
            this.Controls.Add(this.grpTools);
            this.Controls.Add(this.grpAdvanced);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStatus);

            ((System.ComponentModel.ISupportInitialize)(this.numDelayMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdvDelayMs)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
