using System;
using System.Drawing;
using System.Windows.Forms;
using AshX.Core;
using AshX.Models;

namespace AshX
{
    public partial class MainForm : Form
    {
        private WindowManager windowManager = new WindowManager();
        private KeyboardHook keyboardHook = new KeyboardHook();
        private MirrorEngine mirrorEngine = new MirrorEngine();

        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;

            keyboardHook.KeyPressed += KeyboardHook_KeyPressed;

            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10F);

            grpCharacters.BackColor = Color.FromArgb(37, 37, 38);
            grpOptions.BackColor = Color.FromArgb(37, 37, 38);
            grpBlockedKeys.BackColor = Color.FromArgb(37, 37, 38);

            foreach (Control c in this.Controls)
                if (c is Label lbl)
                    lbl.ForeColor = Color.White;

            Color accent = Color.FromArgb(0, 229, 255);

            btnStart.BackColor = accent;
            btnStop.BackColor = accent;
            btnSetMain.BackColor = accent;
            btnSetSecond.BackColor = accent;
            btnAddKey.BackColor = accent;
            btnRemoveKey.BackColor = accent;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshWindowList();
            SettingsManager.Load();

            chkEnableMirroring.Checked = MirrorEngineStatic.Enabled;
            chkEnableDelay.Checked = MirrorEngineStatic.DelayEnabled;
            numDelayMs.Value = MirrorEngineStatic.DelayMs / 1000;
            chkBlockChat.Checked = MirrorEngineStatic.BlockChat;

            lstBlockedKeys.Items.Clear();
            foreach (var key in BlockedKeyService.UserBlocked)
                lstBlockedKeys.Items.Add(key);
        }

        private void RefreshWindowList()
        {
            var windows = windowManager.GetWindows();

            cmbMain.Items.Clear();
            cmbSecond.Items.Clear();

            foreach (var win in windows)
            {
                cmbMain.Items.Add(win);
                cmbSecond.Items.Add(win);
            }

            lblStatus.Text = "Status: Windows Loaded";
        }

        private void btnSetMain_Click(object sender, EventArgs e)
        {
            if (cmbMain.SelectedItem is AOWindow win)
            {
                windowManager.SetMain(win.Handle);
                keyboardHook.MainWindowHandle = win.Handle;

                WindowManagerStatic.MainHandle = win.Handle;

                lblStatus.Text = "Main set: " + win.Title;
            }
        }

        private void btnSetSecond_Click(object sender, EventArgs e)
        {
            if (cmbSecond.SelectedItem is AOWindow win)
            {
                windowManager.SetSecond(win.Handle);

                MirrorEngineStatic.SecondWindowHandle = win.Handle;
                WindowManagerStatic.SecondHandle = win.Handle;

                lblStatus.Text = "Second set: " + win.Title;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            keyboardHook.Install();

            MirrorEngineStatic.Enabled = chkEnableMirroring.Checked;
            MirrorEngineStatic.DelayEnabled = chkEnableDelay.Checked;
            MirrorEngineStatic.DelayMs = (int)(numDelayMs.Value * 1000);
            MirrorEngineStatic.BlockChat = chkBlockChat.Checked;

            lblStatus.Text = "Status: Running";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            keyboardHook.Uninstall();
            MirrorEngineStatic.Enabled = false;

            lblStatus.Text = "Status: Stopped";
        }

        private void KeyboardHook_KeyPressed(Keys key)
        {
            if (chkBlockChat.Checked && key == Keys.Enter)
            {
                MirrorEngineStatic.ChatOpen = !MirrorEngineStatic.ChatOpen;

                lblStatus.Text = MirrorEngineStatic.ChatOpen
                    ? "Status: Chat Open (Mirroring Paused)"
                    : "Status: Chat Closed (Mirroring Active)";

                return;
            }

            mirrorEngine.HandleKey(key);
        }

        private void btnAddKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddKey.Text))
                return;

            if (Enum.TryParse(txtAddKey.Text, true, out Keys key))
            {
                if (BlockedKeyService.AddUserBlocked(key))
                {
                    lstBlockedKeys.Items.Add(key);
                    lblStatus.Text = "Added blocked key: " + key;
                }
            }
        }

        private void btnRemoveKey_Click(object sender, EventArgs e)
        {
            if (lstBlockedKeys.SelectedItem is Keys key)
            {
                BlockedKeyService.RemoveUserBlocked(key);
                lstBlockedKeys.Items.Remove(key);

                lblStatus.Text = "Removed blocked key: " + key;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MirrorEngineStatic.Enabled = chkEnableMirroring.Checked;
            MirrorEngineStatic.DelayEnabled = chkEnableDelay.Checked;
            MirrorEngineStatic.DelayMs = (int)(numDelayMs.Value * 1000);
            MirrorEngineStatic.BlockChat = chkBlockChat.Checked;

            WindowManagerStatic.MainHandle = windowManager.MainHandle;
            WindowManagerStatic.SecondHandle = windowManager.SecondHandle;

            SettingsManager.Save();
        }
    }
}
