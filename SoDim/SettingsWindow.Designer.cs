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
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLegacy = new System.Windows.Forms.TabPage();
            this.tabPageScreens = new System.Windows.Forms.TabPage();
            this.ScreenControls = new System.Windows.Forms.GroupBox();
            this.ScreenSelector = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.screenButton2 = new SoDim.ScreenButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLegacy.SuspendLayout();
            this.tabPageScreens.SuspendLayout();
            this.ScreenSelector.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.tabPageScreens.Controls.Add(this.ScreenControls);
            this.tabPageScreens.Controls.Add(this.ScreenSelector);
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
            this.ScreenControls.Location = new System.Drawing.Point(6, 235);
            this.ScreenControls.Name = "ScreenControls";
            this.ScreenControls.Size = new System.Drawing.Size(340, 91);
            this.ScreenControls.TabIndex = 2;
            this.ScreenControls.TabStop = false;
            this.ScreenControls.Text = "All Screens";
            // 
            // ScreenSelector
            // 
            this.ScreenSelector.BackColor = System.Drawing.SystemColors.Control;
            this.ScreenSelector.Controls.Add(this.screenButton2);
            this.ScreenSelector.Location = new System.Drawing.Point(6, 6);
            this.ScreenSelector.Name = "ScreenSelector";
            this.ScreenSelector.Size = new System.Drawing.Size(340, 200);
            this.ScreenSelector.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dim all screens";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(352, 332);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "About";
            this.tabPageAbout.UseVisualStyleBackColor = true;
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
            // screenButton2
            // 
            this.screenButton2.BackColor = System.Drawing.Color.Transparent;
            this.screenButton2.FirstLine = "Testscreen";
            this.screenButton2.Location = new System.Drawing.Point(77, 46);
            this.screenButton2.Name = "screenButton2";
            this.screenButton2.SecondLine = "80%";
            this.screenButton2.Size = new System.Drawing.Size(192, 108);
            this.screenButton2.TabIndex = 0;
            this.screenButton2.Title = "1";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsWindow";
            this.Text = "SoDim Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLegacy.ResumeLayout(false);
            this.tabPageLegacy.PerformLayout();
            this.tabPageScreens.ResumeLayout(false);
            this.tabPageScreens.PerformLayout();
            this.ScreenSelector.ResumeLayout(false);
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
        private System.Windows.Forms.Panel ScreenSelector;
        private System.Windows.Forms.GroupBox ScreenControls;
        private ScreenButton screenButton1;
        private ScreenButton screenButton2;
    }
}

