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
                workspaceHeight = 0;

            foreach (var screen in Screen.AllScreens)
            {
                Rectangle b = screen.Bounds;
                Debug.WriteLine(b);

                if (b.X + b.Width > workspaceWidth)
                    workspaceWidth = b.X + b.Width;

                if (b.Y + b.Height > workspaceHeight)
                    workspaceHeight = b.Y + b.Height;
            }
            Debug.WriteLine(workspaceWidth + ", " + workspaceHeight);



            double scale = 0.0;
            if (workspaceWidth > workspaceHeight)
            {
                scale = (double) width / workspaceWidth;
            }
            else
            {
                scale = (double) height / workspaceHeight;
            }
            Debug.WriteLine("scale: " + scale);

            int count = 1;
            foreach (var screen in Screen.AllScreens)
            {
                Rectangle b = screen.Bounds;
                int sbWidth = (int)(b.Width * scale);
                int sbHeight = (int)(b.Height * scale);
                int sbX = (int)(b.X * scale);
                int sbY = (int)(b.Y * scale);
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
