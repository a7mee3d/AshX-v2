using System;

namespace AshX.Models
{
    public class AOWindow
    {
        public string Title { get; set; }
        public IntPtr Handle { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
