using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDim
{
    public partial class ScreenSelector : UserControl
    {
        public ScreenButton Selected { get; set; }

        public ScreenSelector()
        {
            InitializeComponent();

            int count = 1;
            foreach (var screen in Screen.AllScreens)
            {
                ScreenButton sb = new ScreenButton(new Size(screen.Bounds.Width / 10, screen.Bounds.Height / 10), count.ToString(), screen.DeviceName, "0%");
                int x = (count - 1) * 100;
                sb.Location = new Point(x, 0);
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
