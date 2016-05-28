using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoDim
{
    public partial class ScreenButton : UserControl
    {
        public event EventHandler CheckedChanged;

        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }

        public string FirstLine
        {
            get
            {
                return line2.Text;
            }
            set
            {
                line2.Text = value;
            }
        }

        public string SecondLine
        {
            get
            {
                return line1.Text;
            }
            set
            {
                line1.Text = value;
            }
        }

        public ScreenButton()
        {
            InitializeComponent();
            title.Parent = button;
            line1.Parent = button;
            line2.Parent = button;
        }

        public ScreenButton(string title = "", string firstLine = "", string secondLine = ""): this()
        {
            this.Title = title;
            this.FirstLine = firstLine;
            this.SecondLine = secondLine;
        }

        public ScreenButton(Size size, string title = "", string firstLine = "", string secondLine = ""): this(title, firstLine, secondLine)
        {
            this.Size = size;
        }

        private void button_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckedChanged == null)
                return;

            CheckedChanged.Invoke(sender, e);
        }
    }
}
