using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDiscountLabel();
        }
        private void InitializeDiscountLabel()
        {
            DiscountLabel discountLabel = new DiscountLabel
            {
                Location = new Point(10, 10),
                Size = new Size(400, 50),
                Font = new Font("Arial", 12),
                ForeColor = Color.Gray
            };

            Controls.Add(discountLabel);

            // Set the label text
            discountLabel.Text = "Original Price: $100.00   Discounted Price: $80.00";

            // Specify the position of the line
            discountLabel.UnderlinePosition = 5;
        }
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
