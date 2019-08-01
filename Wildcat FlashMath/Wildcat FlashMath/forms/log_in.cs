using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Wildcat_FlashMath
{
    public partial class Form1 : Form
    {
        public static string username;
        public static double time;
        public static int score;
        public static string grade;
        main_menu main = new main_menu();



        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {


            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string s = "2017-10-01";

            main.CreateControl();
            main.CreateGraphics();


            DateTime dt =
                DateTime.Parse(s);
            //if (DateTime.Today > dt)
            //{
            //    MessageBox.Show("Unlicensed copy");
            //    Application.Exit();
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Wildcat_FlashMath.Properties.Resources.lion_roar);
            player.Play();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
            loading_background loading = new loading_background();
            loading.Show();
            main.Show();
            this.Hide();


        }

    }
}
