using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MetroFramework.Drawing.MetroPaint;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace HMS.Utils
{
    internal class MarkUp
    {
    }
    public class DiscountLabel : Label
    {
        public int UnderlinePosition { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the text
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor);

            // Draw the underline in the middle of the string
            if (UnderlinePosition >= 0 && UnderlinePosition < Text.Length)
            {
                Size textSize = TextRenderer.MeasureText(Text, Font);
                Size underlineSize = TextRenderer.MeasureText(Text.Substring(0, UnderlinePosition), Font);

                int underlineX = underlineSize.Width;
                int underlineY = textSize.Height / 4 + Font.Height / 4; // Adjust the Y position as needed
                int underlineWidth = TextRenderer.MeasureText(Text.Substring(UnderlinePosition, 4), Font).Width;

                e.Graphics.FillRectangle(new SolidBrush(ForeColor), underlineX, underlineY, underlineWidth, 1);
            }
        }
    }
}
