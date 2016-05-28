using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDim
{
    public partial class SettingsWindow : Form
    {
        private OverlayWindow overlay;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            if (overlay != null)
                overlay.SetOpacity(((double)trackBar1.Value) / 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (overlay == null)
            {
                Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
                overlay = new OverlayWindow(new Point(screenBounds.X, screenBounds.Y), new Size(screenBounds.Width, screenBounds.Height), ((double)trackBar1.Value) / 100);
                overlay.Owner = null;
                overlay.Show();
            }
            else
            {
                overlay.Hide();
                overlay = null;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value > 90)
            {
                trackBar2.Value = 100;
                label2.Text = "Blank";
            }
            else
            {
                label2.Text = trackBar2.Value + "%";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //SoDim.ScreenSelector.Enabled = !checkBox1.Checked;
        }
    }
}
