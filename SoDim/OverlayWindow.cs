using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDim
{
    public partial class OverlayWindow : Form
    {
        public OverlayWindow(Size size, double opacity)
        {
            InitializeComponent();
            this.Size = size;
            this.Opacity = opacity;
        }
    }
}
