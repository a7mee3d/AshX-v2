using System;

namespace AshX.Core
{
    public static class MirrorEngineStatic
    {
        public static bool Enabled = false;

        public static bool DelayEnabled = false;
        public static int DelayMs = 0;

        public static bool BlockChat = false;
        public static bool ChatOpen = false;

        public static IntPtr MainWindowHandle = IntPtr.Zero;
        public static IntPtr SecondWindowHandle = IntPtr.Zero;
    }
}
