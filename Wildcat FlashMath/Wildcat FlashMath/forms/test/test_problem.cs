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
    public partial class test_problem : Form
    {
        public static int sign;
        public static int num1;
        public static int num2;
        public static double time = 0;
        public static string user;
        public static int score = 0;
        public static string grade;


        public test_problem()
        {
            InitializeComponent();
            
        }

        private void test_problem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;
            label2.Text = Form1.username;
            label3.Text = "Grade: " + Form1.grade;


            Random rnd1 = new Random();
            num1 = rnd1.Next(1, 20);

            Random rnd2 = new Random();
            sign = rnd2.Next(1, 2);
            string sign_str;
            if (sign == 1)
            {
                sign_str = "+";
            }
            else
            {
                sign_str = "-";
            }

            Random rnd3 = new Random();
            num2 = rnd3.Next(1, 20);

            if (num2 == num1)
            {
                num2 = num2 + 3;
            }

            label4.Text = num1 + " " + sign_str + " " + num2 + " =";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool answer = false;
            if (sign == 1)
            {
                if (Convert.ToInt32(textBox1.Text)== num2+ num1)
                {
                    answer = true;
                    score = 1;
                }
            }
            if (sign == 2)
            {
                if (Convert.ToInt32(textBox1.Text)== num1 - num2)
                {
                    answer = true;
                    score = 1;
                }
            }
            if (answer)
            {
                correct correct = new correct();
                correct.Show();
            }
            else
            {
                wrong wrong = new wrong();
                wrong.Show();
            }
            timer1.Enabled = false;
            grade = main_menu.Grade;
            user = main_menu.User;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + 0.1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.BackgroundImage == null)
            {
                return;
            }
            var bm = new Bitmap(this.tableLayoutPanel1.BackgroundImage, new Size(tableLayoutPanel1.Size.Width, tableLayoutPanel1.Height));
            tableLayoutPanel1.BackgroundImage = bm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_menu mainMenu = new main_menu();
            mainMenu.Show();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
