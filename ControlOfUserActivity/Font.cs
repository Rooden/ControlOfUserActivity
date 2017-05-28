using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using ControlOfUserActivity.Properties;

namespace ControlOfUserActivity
{
    public class AppFont
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [In] ref uint pcFonts);

        private static FontFamily _ff;

        private static void LoadExo2Font()
        {
            if (_ff != null) return;

            var fontArray = Resources.Exo2_Regular;
            var dataLenght = Resources.Exo2_Regular.Length;

            var ptrData = Marshal.AllocCoTaskMem(dataLenght);
            Marshal.Copy(fontArray, 0, ptrData, dataLenght);

            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            var pcf = new PrivateFontCollection();
            pcf.AddMemoryFont(ptrData, dataLenght);
            Marshal.FreeCoTaskMem(ptrData);

            _ff = pcf.Families[0];
        }

        public static void SetExo2Font(System.Windows.Forms.Control c, float size, FontStyle style = FontStyle.Regular)
        {
            LoadExo2Font();
            c.Font = new Font(_ff, size, style);
        }
    }
}
