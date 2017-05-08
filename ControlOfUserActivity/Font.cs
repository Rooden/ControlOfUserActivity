using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using ControlOfUserActivity.Properties;

namespace ControlOfUserActivity
{
    public class Font
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [In] ref uint pcFonts);

        private FontFamily _ff;

        private void LoadExo2Font()
        {
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

        public void SetExo2Font(System.Windows.Forms.Control c, float size, FontStyle style = FontStyle.Regular)
        {
            LoadExo2Font();
            c.Font = new System.Drawing.Font(_ff, size, style);
        }
    }
}
