using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoDim
{
    public partial class ScreenSelector : UserControl
    {
        public ScreenButton Selected { get; set; }

        public ScreenSelector()
        {
            InitializeComponent();

            int width = this.Size.Width,
                height = this.Size.Height,
                workspaceWidth = 0,
                workspaceHeight = 0,
                maxX = 0,
                minX = 0,
                maxY = 0,
                minY = 0;

            foreach (var screen in Screen.AllScreens)
            {
                Rectangle b = screen.Bounds;
                Debug.WriteLine(b);

                if (b.X < minX)
                    minX = b.X;
                if (b.X + b.Width > maxX)
                    maxX = b.X + b.Width;

                if (b.Y < minY)
                    minY = b.Y;
                if (b.Y + b.Height > maxY)
                    maxY = b.Y + b.Height;
            }
            workspaceWidth = maxX - minX;
            workspaceHeight = maxY - minY;

            Debug.WriteLine(workspaceWidth + ", " + workspaceHeight);

            //scaling factor to fit the workspace into the viewport
            double scale = 0.0,
                   invscale = 0.0;
            if (workspaceWidth > workspaceHeight)
            {
                scale = (double)width / workspaceWidth;
                invscale = (double)workspaceWidth / width;
            }
            else
            {
                scale = (double)height / workspaceHeight;
                invscale = (double)workspaceHeight / height;
            }
            Debug.WriteLine("scale: {0}, invscale: {1}", scale, invscale);

            //offset to only get positive coordinates
            int offsetX = 0,
                offsetY = 0;
            
            if (minX < 0)
                offsetX = 0 - minX;
            if (minY < 0)
                offsetY = 0 - minY;

            int count = 1;
            foreach (var screen in Screen.AllScreens)
            {
                Rectangle b = screen.Bounds;
                int sbWidth = (int)(b.Width * scale);
                int sbHeight = (int)(b.Height * scale);
                int sbX = (int)((b.X + offsetX) * scale);
                int sbY = (int)((b.Y + offsetY) * scale);
                Debug.WriteLine(sbX + ", " + sbY + ", " + sbWidth + ", " + sbHeight);

                ScreenButton sb = new ScreenButton(new Size(sbWidth, sbHeight), count.ToString(), screen.DeviceName, "0%");
                sb.Location = new Point(sbX, sbY);
                sb.CheckedChanged += ScreenButtons_CheckedChanged;

                this.Controls.Add(sb);
                count++;
            }

        }

        private void ScreenButtons_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if ((sender as ScreenButton).Checked == true && c is ScreenButton && c != sender)
                {
                    Selected = sender as ScreenButton;
                    (c as ScreenButton).Checked = false;
                }
            }
        }
    }
}
