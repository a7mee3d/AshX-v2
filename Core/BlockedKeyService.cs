using System.Collections.Generic;
using System.Windows.Forms;

namespace AshX.Core
{
    public static class BlockedKeyService
    {
        private static readonly HashSet<Keys> PermanentBlocked = new HashSet<Keys>
        {
            Keys.W, Keys.A, Keys.S, Keys.D,
            Keys.Z, Keys.X, Keys.C,
            Keys.Up, Keys.Down, Keys.Left, Keys.Right,
            Keys.Enter,
            Keys.OemQuestion
        };

        public static HashSet<Keys> UserBlocked = new HashSet<Keys>();

        public static bool IsBlocked(Keys key)
        {
            return PermanentBlocked.Contains(key) || UserBlocked.Contains(key);
        }

        public static bool AddUserBlocked(Keys key)
        {
            return UserBlocked.Add(key);
        }

        public static bool RemoveUserBlocked(Keys key)
        {
            return UserBlocked.Remove(key);
        }
    }
}
