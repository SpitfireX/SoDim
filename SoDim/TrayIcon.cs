using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDim
{
    class TrayIcon
    {
        public bool Visible
        {
            get
            {
                return Icon.Visible;
            }
            set
            {
                Icon.Visible = value;
            }
        }
        //Component declarations
        private NotifyIcon Icon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem CloseMenuItem;

        public TrayIcon()
        {
            InitializeComponent();
            Icon.Visible = true;
        }

        private void InitializeComponent()
        {
            Icon = new NotifyIcon();

            Icon.BalloonTipIcon = ToolTipIcon.Info;
            Icon.BalloonTipText =
              "I noticed that you double-clicked me! What can I do for you?";
            Icon.BalloonTipTitle = "You called Master?";
            Icon.Text = "My fabulous tray icon demo application";


            //The icon is added to the project resources.
            //Here I assume that the name of the file is 'TrayIcon.ico'
            Icon.Icon = Properties.Resources.TrayIcon;

            //Optional - handle doubleclicks on the icon:
            Icon.DoubleClick += TrayIcon_DoubleClick;

            //Optional - Add a context menu to the TrayIcon:
            TrayIconContextMenu = new ContextMenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            TrayIconContextMenu.SuspendLayout();

            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {
            this.CloseMenuItem});
            this.TrayIconContextMenu.Name = "TrayIconContextMenu";
            this.TrayIconContextMenu.Size = new Size(153, 70);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new Size(152, 22);
            this.CloseMenuItem.Text = "Close the tray icon program";
            this.CloseMenuItem.Click += new EventHandler(this.CloseMenuItem_Click);

            TrayIconContextMenu.ResumeLayout(false);
            Icon.ContextMenuStrip = TrayIconContextMenu;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            App.Instance.ShowSettings();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close SoDim?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
