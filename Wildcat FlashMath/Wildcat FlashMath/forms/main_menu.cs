using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Wildcat_FlashMath
{
    public partial class main_menu : Form
    {
        public static string Grade;
        public static string User;
        public main_menu()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;



        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            Form1.grade = "";
            SetAllControlsFont(tableLayoutPanel1.Controls);

            timer1.Enabled = true;

        }
        public void SetAllControlsFont(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls);
                ctrl.Margin = new Padding(0, 0, 0, 0);
                if (Screen.PrimaryScreen.Bounds.Width < 1400)
                {
                    ctrl.Font = new Font("Impact", ctrl.Font.Size / 4);
                    ctrl.Font = new Font("Impact", ctrl.Font.Size * 3);
                    if (Screen.PrimaryScreen.Bounds.Width < 1000)
                    {
                        ctrl.Font = new Font("Impact", ctrl.Font.Size / 4);
                        ctrl.Font = new Font("Impact", ctrl.Font.Size * 3);

                    }
                }

            }
            textBox1.Font = new Font("Impact", 51);
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {

                try
                {
                    Grade = "K";
                    User = textBox1.Text;

                    Form1.username = textBox1.Text;
                    Form1.grade = "K";

                    problem_select_test problem_select = new problem_select_test();
                    problem_select.Show();

                    this.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }

            else
            {

                Grade = "1";
                User = textBox1.Text;

                Form1.username = textBox1.Text;
                Form1.grade = "1";

                problem_select_test problem_select = new problem_select_test();
                problem_select.Show();


                this.Close();
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }

            else
            {

                Grade = "2";
                User = textBox1.Text;

                Form1.username = textBox1.Text;
                Form1.grade = "2";

                problem_select_test problem_select = new problem_select_test();
                problem_select.Show();


                this.Close();
            }




        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }

            else
            {

                Grade = "3";
                User = textBox1.Text;

                Form1.username = textBox1.Text;
                Form1.grade = "3";

                problem_select_test problem_select = new problem_select_test();
                problem_select.Show();


                this.Close();
            }




        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }

            else
            {

                Grade = "4";
                User = textBox1.Text;

                Form1.username = textBox1.Text;
                Form1.grade = "4";

                problem_select_test problem_select = new problem_select_test();
                problem_select.Show();


                this.Close();
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }

            else
            {

                Grade = "5";
                User = textBox1.Text;

                Form1.username = textBox1.Text;
                Form1.grade = "5";

                problem_select_test problem_select = new problem_select_test();
                problem_select.Show();


                this.Close();
            }




        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(((1 + 2)) - 3 * 4 / 5 + 6));
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            enter_email enter = new enter_email();
            enter.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (Properties.Settings.Default["email"].ToString() == "null" || Properties.Settings.Default["email"].ToString() == "email")
            {
                enter_email enter = new enter_email();
                enter.Show();
            }
        }
    }
}
