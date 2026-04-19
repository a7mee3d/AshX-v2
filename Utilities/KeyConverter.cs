using System;
using System.Windows.Forms;

namespace AshX.Utilities
{
    public static class KeyConverter
    {
        public static bool TryParse(string input, out Keys key)
        {
            return Enum.TryParse(input, true, out key);
        }

        public static string ToString(Keys key)
        {
            return key.ToString();
        }
    }
}
