using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AshX.Utilities;

namespace AshX.Core
{
    public class KeyboardHook
    {
        private IntPtr hookId = IntPtr.Zero;
        private WinApi.LowLevelKeyboardProc proc;

        public event Action<Keys> KeyPressed;

        public IntPtr MainWindowHandle { get; set; }

        public KeyboardHook()
        {
            proc = HookCallback;
        }

        public void Install()
        {
            IntPtr hInstance = WinApi.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);
            hookId = WinApi.SetWindowsHookEx(WinApi.WH_KEYBOARD_LL, proc, hInstance, 0);
        }

        public void Uninstall()
        {
            if (hookId != IntPtr.Zero)
            {
                WinApi.UnhookWindowsHookEx(hookId);
                hookId = IntPtr.Zero;
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 &&
                (wParam == (IntPtr)WinApi.WM_KEYDOWN || wParam == (IntPtr)WinApi.WM_SYSKEYDOWN))
            {
                if (WinApi.GetForegroundWindow() == MainWindowHandle)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    Keys key = (Keys)vkCode;

                    KeyPressed?.Invoke(key);
                }
            }

            return WinApi.CallNextHookEx(hookId, nCode, wParam, lParam);
        }
    }
}
