using System;
using System.Drawing;

namespace Domain
{
    public class BitmapComparer : IControllableComparer<Bitmap>
    {
        public int SizeShrink = 10;

        public int Accuracy
        {
            get => 10 * SizeShrink;
            set => SizeShrink = value / 10;
        }

        public int ColorShrink = 32;
        public int Tolerance { get;set; } = 4;
        public int MaxGlitches = 32;

        public int Compare(Bitmap a, Bitmap b)
        {
            if (a == null && b != null) return 1;
            if (b == null) return 0;

            // gray-en-ize
            ShrinkPalette(a);
            ShrinkPalette(b);
            a.Save(@"C:\Repositories\paletteshrunkA.bmp");
            b.Save(@"C:\Repositories\paletteshrunkB.bmp");

            // shrink
            var smalla = Scale(a);
            var smallb = Scale(b, smalla.Size);
            smalla.Save(@"C:\Repositories\paletteAndSizeShrunkA.bmp");
            smallb.Save(@"C:\Repositories\paletteAndSizeShrunkB.bmp");

            // result count
            var glitches = 0;

            // result image
            var changeMap = new Bitmap(smalla.Width, smalla.Height);

            for (var x =0; x < smalla.Width; x++)
            {
                for (var y = 0; y < smalla.Height; y++)
                {
                    var xyA = smalla.GetPixel(x, y);
                    var xyB = smallb.GetPixel(x, y);
                    var match = GetDiff(xyA, xyB);

                    changeMap.SetPixel(x,y, match);

                    if (!IsBlack(match))
                        glitches++;
                }
            }

            changeMap.Save(@"C:\Repositories\changemap.bmp");

            return glitches == 0 ? 0 : 1;
        }

        private bool IsBlack(Color color)
        {
            //if (color.R > Tolerance || 
            //    color.G > Tolerance || 
            //    color.B > Tolerance) 
            //    return false;
            if (color.R + color.G + color.B > Tolerance)
                return false;

            return true;
        }

        private Color GetDiff(Color xyA, Color xyB)
        {
            var r = Math.Abs(xyA.R - xyB.R);
            var g = Math.Abs(xyA.G - xyB.G);
            var b = Math.Abs(xyA.B - xyB.B);

            var avg = (r + g + b) / 3;

            if (r <= Tolerance && g <= Tolerance && b <= Tolerance)
                return Color.Black;

            return Color.FromArgb(avg,avg,avg);
        }

        private void ShrinkPalette(Bitmap source)
        {
            for(var i = 0; i < source.Palette.Entries.Length; i++)
            {
                var color = source.Palette.Entries[i];
                var newColor = Color.FromArgb(color.A, color.R / ColorShrink, color.G / ColorShrink, color.B / ColorShrink);
                source.Palette.Entries[i] = newColor;
            }
        }

        private Bitmap Scale(Bitmap source, Size? size = null)
        {
            size = size ?? new Size(source.Width / SizeShrink, source.Height / SizeShrink);
            return new Bitmap(source, size.Value);
        }
    }
}
