using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TokenIcer
{
    public sealed class TokenIcerCheckBox : CheckBox
    {
        public TokenIcerCheckBox()
        {
            Appearance = Appearance.Button;
            FlatStyle = FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleRight;
            FlatAppearance.BorderSize = 0;
            AutoSize = false;
            Height = 26;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.Clear(BackColor);

            using (SolidBrush brush = new SolidBrush(ForeColor))
                pevent.Graphics.DrawString(Text, Font, brush, 27, 4);

            Point pt = new Point(4, 4);
            Rectangle rect = new Rectangle(pt, new Size(16, 16));

            var br = Checked
                ? new SolidBrush(Color.FromArgb(125, 125, 125))
                : new SolidBrush(Color.FromArgb(105, 105, 105));

            pevent.Graphics.FillRectangle(br, rect);

            if (Checked)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(191, 255, 191)))
                {
                    using (Font wing = new Font("Wingdings", 15f))
                    {
                        pevent.Graphics.DrawString("ü", wing, brush, 1, 3);
                    }
                }
            }

            pevent.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 255, 255)), rect);

            Rectangle fRect = ClientRectangle;

            if (Focused)
            {
                fRect.Inflate(-1, -1);
                using (Pen pen = new Pen(Brushes.Gray) { DashStyle = DashStyle.Dot })
                    pevent.Graphics.DrawRectangle(pen, fRect);
            }
        }
    }
}
