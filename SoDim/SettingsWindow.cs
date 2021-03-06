﻿using System;
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
            Icon = Properties.Resources.Icon;
            pictureBox.Image = Bitmap.FromHicon(Properties.Resources.Icon.Handle);
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
                Rectangle screenBounds = Screen.AllScreens[2].Bounds;
                overlay = new OverlayWindow(screenBounds.Location, screenBounds.Size, ((double)trackBar1.Value) / 100);
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
            ScreenSelector.Enabled = !checkBox1.Checked;
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void aboutTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
