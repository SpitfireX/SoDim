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
                overlay.Opacity = ((double)trackBar1.Value) / 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (overlay == null)
            {
                double opacity = ((double) trackBar1.Value) / 100;
                Debug.WriteLine(opacity);
                overlay = new OverlayWindow(new Size(600, 600), opacity);
                overlay.Show();
            }
            else
            {
                overlay.Hide();
                overlay = null;
            }
        }
    }
}
