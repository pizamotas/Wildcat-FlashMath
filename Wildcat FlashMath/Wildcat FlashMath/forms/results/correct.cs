using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Wildcat_FlashMath
{
    public partial class correct : Form
    {
        public correct()
        {
            InitializeComponent();
        }

        private void correct_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
            SoundPlayer audio = new SoundPlayer(Wildcat_FlashMath.Properties.Resources.correct);
            audio.Play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
