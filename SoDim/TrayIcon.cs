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
                return icon.Visible;
            }
            set
            {
                icon.Visible = value;
            }
        }
        //Component declarations
        private NotifyIcon icon;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem closeItem;
        private ToolStripMenuItem settingsItem;

        public TrayIcon()
        {
            InitializeComponent();
            icon.Visible = true;
        }

        private void InitializeComponent()
        {
            icon = new NotifyIcon();
            icon.Text = "SoDim";


            //Icon from project resources.
            icon.Icon = Properties.Resources.TrayIcon;

            //Handle doubleclicks on the icon:
            icon.DoubleClick += TrayIcon_DoubleClick;

            //Add a context menu to the TrayIcon:
            contextMenu = new ContextMenuStrip();
            closeItem = new ToolStripMenuItem();
            settingsItem = new ToolStripMenuItem();
            contextMenu.SuspendLayout();

            // 
            // trayIconContextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] {
                settingsItem, closeItem});
            contextMenu.Name = "trayIconContextMenu";
            contextMenu.Size = new Size(153, 70);
            // 
            // closeItem
            // 
            closeItem.Name = "closeItem";
            closeItem.Size = new Size(152, 22);
            closeItem.Text = "Close";
            closeItem.Click += new EventHandler(CloseItem_Click);
            // 
            // settingsItem
            // 
            settingsItem.Name = "settingsItem";
            settingsItem.Size = new Size(152, 22);
            settingsItem.Text = "Settings";
            settingsItem.Click += new EventHandler(SettingsItem_Click);

            contextMenu.ResumeLayout(false);
            icon.ContextMenuStrip = contextMenu;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            App.Instance.ShowSettings();
        }

        private void CloseItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close SoDim?",
                    "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void SettingsItem_Click(object sender, EventArgs e)
        {
            App.Instance.ShowSettings();
        }
    }
}
