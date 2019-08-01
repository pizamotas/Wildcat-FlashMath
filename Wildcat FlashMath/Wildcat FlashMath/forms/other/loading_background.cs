using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wildcat_FlashMath
{
    public partial class loading_background : Form
    {
        public loading_background()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;


        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (this.pictureBox1.BackgroundImage == null)
            {
                return;
            }
            var bm = new Bitmap(this.pictureBox1.BackgroundImage, new Size(pictureBox1.Size.Width, pictureBox1.Height));
            pictureBox1.BackgroundImage = bm;

        }
    }
}
