using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDim
{
    public class ScreenButton : RadioButton
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public ScreenButton(Size size, string title, string subtitle) : base()
        {
            Appearance = Appearance.Button;
            Size = size;
            Title = title;
            Subtitle = subtitle;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = e.ClipRectangle;
            Graphics g = e.Graphics;

            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;
            titleFormat.LineAlignment = StringAlignment.Center;

            StringFormat subtitleFormat = new StringFormat();
            subtitleFormat.Alignment = StringAlignment.Center;
            subtitleFormat.LineAlignment = StringAlignment.Far;

            Font titleFont = new Font(Font.Name, rect.Height * 0.7F, FontStyle.Bold);
            Font subtitleFont = new Font(Font.Name, 12, FontStyle.Regular);

            if (Enabled)
            {
                g.DrawString(Title, titleFont, SystemBrushes.ControlDarkDark, rect, titleFormat);
                g.DrawString(Subtitle, subtitleFont, SystemBrushes.ControlText, rect, subtitleFormat);
            }
            else
            {
                g.DrawString(Title, titleFont, SystemBrushes.ControlDark, rect, titleFormat);
                g.DrawString(Subtitle, subtitleFont, SystemBrushes.ControlDarkDark, rect, subtitleFormat);
            }
        }
    }
}
