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
    public partial class wrong : Form
    {
        public string answer;
        public string ans_bot;
        public bool frac = false;
        public wrong()
        {
            InitializeComponent();
        }

        private void wrong_Load(object sender, EventArgs e)
        {
            if (frac)
            {
                frac_pnl.Visible = true;
                text_pnl.Visible = false;
                ans_frac_top.Text = answer;
                ans_frac_bot.Text = ans_bot;
            }
            else
            {
                frac_pnl.Visible = false;
                text_pnl.Visible = true;
                answer_text.Text = answer;
            }
            SoundPlayer audio = new SoundPlayer(Wildcat_FlashMath.Properties.Resources.wrong);
            audio.Play();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (answer == null)
            {
                this.Close();
            }
        }

        private void frac_line_2_Click(object sender, EventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
