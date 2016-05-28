using System.Drawing;

namespace SoDim
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLegacy = new System.Windows.Forms.TabPage();
            this.tabPageScreens = new System.Windows.Forms.TabPage();
            this.ScreenControls = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ScreenSelector = new SoDim.ScreenSelector();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLegacy.SuspendLayout();
            this.tabPageScreens.SuspendLayout();
            this.ScreenControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toggle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Location = new System.Drawing.Point(3, 96);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(346, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLegacy);
            this.tabControl1.Controls.Add(this.tabPageScreens);
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 358);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageLegacy
            // 
            this.tabPageLegacy.Controls.Add(this.label1);
            this.tabPageLegacy.Controls.Add(this.trackBar1);
            this.tabPageLegacy.Controls.Add(this.button1);
            this.tabPageLegacy.Location = new System.Drawing.Point(4, 22);
            this.tabPageLegacy.Name = "tabPageLegacy";
            this.tabPageLegacy.Size = new System.Drawing.Size(352, 332);
            this.tabPageLegacy.TabIndex = 2;
            this.tabPageLegacy.Text = "Legacy";
            this.tabPageLegacy.UseVisualStyleBackColor = true;
            // 
            // tabPageScreens
            // 
            this.tabPageScreens.Controls.Add(this.ScreenSelector);
            this.tabPageScreens.Controls.Add(this.ScreenControls);
            this.tabPageScreens.Controls.Add(this.checkBox1);
            this.tabPageScreens.Location = new System.Drawing.Point(4, 22);
            this.tabPageScreens.Name = "tabPageScreens";
            this.tabPageScreens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScreens.Size = new System.Drawing.Size(352, 332);
            this.tabPageScreens.TabIndex = 0;
            this.tabPageScreens.Text = "Screens";
            this.tabPageScreens.UseVisualStyleBackColor = true;
            // 
            // ScreenControls
            // 
            this.ScreenControls.Controls.Add(this.label5);
            this.ScreenControls.Controls.Add(this.label4);
            this.ScreenControls.Controls.Add(this.label3);
            this.ScreenControls.Controls.Add(this.label2);
            this.ScreenControls.Controls.Add(this.trackBar2);
            this.ScreenControls.Location = new System.Drawing.Point(6, 235);
            this.ScreenControls.Name = "ScreenControls";
            this.ScreenControls.Size = new System.Drawing.Size(340, 94);
            this.ScreenControls.TabIndex = 2;
            this.ScreenControls.TabStop = false;
            this.ScreenControls.Text = "All Screens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blank";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "90%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "0%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "0%";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar2.Location = new System.Drawing.Point(3, 19);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(334, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dim all screens";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(352, 332);
            this.tabPageGeneral.TabIndex = 1;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.webBrowser1);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(352, 332);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(352, 332);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://spitfirex.net", System.UriKind.Absolute);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "lmao";
            this.notifyIcon1.BalloonTipTitle = "ayy";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "u wot m8";
            this.notifyIcon1.Visible = true;
            // 
            // ScreenSelector
            // 
            this.ScreenSelector.BackColor = System.Drawing.SystemColors.Control;
            this.ScreenSelector.Enabled = false;
            this.ScreenSelector.Location = new System.Drawing.Point(6, 6);
            this.ScreenSelector.Name = "ScreenSelector";
            this.ScreenSelector.Selected = null;
            this.ScreenSelector.Size = new System.Drawing.Size(340, 200);
            this.ScreenSelector.TabIndex = 3;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoDim Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLegacy.ResumeLayout(false);
            this.tabPageLegacy.PerformLayout();
            this.tabPageScreens.ResumeLayout(false);
            this.tabPageScreens.PerformLayout();
            this.ScreenControls.ResumeLayout(false);
            this.ScreenControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabPageAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageScreens;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageLegacy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.GroupBox ScreenControls;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ScreenSelector ScreenSelector;
    }
}

