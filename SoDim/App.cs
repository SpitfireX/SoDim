using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDim
{
    class App : ApplicationContext
    {
        public static App Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new App();
                }
                return instance;
            }
        }
        private static App instance;

        private TrayIcon trayIcon;
        private SettingsWindow settingsWindow;

        public App()
        {
            trayIcon = new TrayIcon();
            settingsWindow = new SettingsWindow();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        public void ShowSettings()
        {
            settingsWindow.Show();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //Cleanup so that the icon will be removed when the application is closed
            trayIcon.Visible = false;
        }
    }
}
