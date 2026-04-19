using System;
using System.Threading;
using System.Windows.Forms;
using AshX.Utilities;

namespace AshX.Core
{
    public class MirrorEngine
    {
        private readonly Sender sender = new Sender();

        public void HandleKey(Keys key)
        {
            if (!MirrorEngineStatic.Enabled)
                return;

            if (MirrorEngineStatic.SecondWindowHandle == IntPtr.Zero)
                return;

            if (MirrorEngineStatic.BlockChat && MirrorEngineStatic.ChatOpen)
                return;

            if (BlockedKeyService.IsBlocked(key))
                return;

            if (MirrorEngineStatic.DelayEnabled && MirrorEngineStatic.DelayMs > 0)
            {
                int delay = MirrorEngineStatic.DelayMs;

                ThreadPool.QueueUserWorkItem(_ =>
                {
                    Thread.Sleep(delay);
                    sender.SendKey(MirrorEngineStatic.SecondWindowHandle, (int)key);
                });
            }
            else
            {
                sender.SendKey(MirrorEngineStatic.SecondWindowHandle, (int)key);
            }
        }
    }
}
