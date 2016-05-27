namespace SoDim
{
    partial class ScreenButton
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(192, 108);
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(62, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(69, 73);
            this.title.TabIndex = 1;
            this.title.Text = "1";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(66, 95);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(60, 13);
            this.line1.TabIndex = 2;
            this.line1.Text = "Testscreen";
            this.line1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line2
            // 
            this.line2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.line2.AutoSize = true;
            this.line2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2.Location = new System.Drawing.Point(74, 65);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(45, 24);
            this.line2.TabIndex = 3;
            this.line2.Text = "80%";
            this.line2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.line2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.button);
            this.Name = "ScreenButton";
            this.Size = new System.Drawing.Size(192, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
    }
}
