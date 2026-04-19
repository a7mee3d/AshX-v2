using System;
using System.Collections.Generic;
using System.Text;
using AshX.Models;
using AshX.Utilities;

namespace AshX.Core
{
    public class WindowManager
    {
        public IntPtr MainHandle { get; private set; }
        public IntPtr SecondHandle { get; private set; }

        public List<AOWindow> GetWindows()
        {
            List<AOWindow> list = new List<AOWindow>();

            WinApi.EnumWindows((hWnd, lParam) =>
            {
                if (!WinApi.IsWindowVisible(hWnd))
                    return true;

                int length = WinApi.GetWindowTextLength(hWnd);
                if (length == 0)
                    return true;

                StringBuilder sb = new StringBuilder(length + 1);
                WinApi.GetWindowText(hWnd, sb, sb.Capacity);

                string title = sb.ToString();

                if (title.Contains("Anarchy Online"))
                {
                    list.Add(new AOWindow
                    {
                        Title = title,
                        Handle = hWnd
                    });
                }

                return true;

            }, IntPtr.Zero);

            return list;
        }

        public void SetMain(IntPtr handle)
        {
            MainHandle = handle;
        }

        public void SetSecond(IntPtr handle)
        {
            SecondHandle = handle;
        }
    }
}
