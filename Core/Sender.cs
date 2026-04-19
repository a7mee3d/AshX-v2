using System;
using AshX.Utilities;

namespace AshX.Core
{
    public class Sender
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        public void SendKey(IntPtr hWnd, int keyCode)
        {
            if (hWnd == IntPtr.Zero)
                return;

            WinApi.PostMessage(hWnd, WM_KEYDOWN, (IntPtr)keyCode, IntPtr.Zero);
            WinApi.PostMessage(hWnd, WM_KEYUP, (IntPtr)keyCode, IntPtr.Zero);
        }
    }
}
