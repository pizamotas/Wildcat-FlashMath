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
    public partial class problem_select_test : Form
    {
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

        private List<string> problem_list = new List<string>();
        public problem_select_test()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = null;




        }


        public void checkbox_test()
        {
            string checked_boxes = "";
            int number_of_boxes = 0;

            List<string> problemsList = new List<string>();
            CheckBox[] box = new CheckBox[8];
            box[0] = checkBox1;
            box[1] = checkBox2;
            box[2] = checkBox3;
            box[3] = checkBox4;
            box[4] = checkBox5;
            box[5] = checkBox6;
            box[6] = checkBox7;
            box[7] = checkBox8;

            switch (Form1.grade)
            {
                case "1":
                    number_of_boxes = 4;
                    break;
                case "2":
                    number_of_boxes = 5;
                    break;
                case "3":
                    number_of_boxes = 5;
                    break;
                case "4":
                    number_of_boxes = 8;
                    break;
                case "5":
                    number_of_boxes = 8;
                    break;
                case "K":
                    number_of_boxes = 3;
                    break;

            }


            for (int i = 0; i < number_of_boxes; i++)
            {
                try
                {
                    if (box[i].Checked)
                    {
                        problemsList.Add(box[i].Text);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            problem_list = problemsList;
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
        }

        private void problem_select_test_Load(object sender, EventArgs e)
        {

            SetAllControlsFont(tableLayoutPanel1.Controls);
            label3.Text = Form1.username;
            label2.Text = "Grade: " + Form1.grade;
            string grade = Form1.grade;

            if (grade == "1")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Counting money";
                butoon_4.Text = "Telling time";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "money";
                checkBox4.Text = "time";

                button_5.Visible = false;
                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_5.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;
            }
            else if (grade == "2")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Counting money";
                butoon_4.Text = "Telling time";
                button_5.Text = "Fractions";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "money";
                checkBox4.Text = "time";
                checkBox5.Text = "fractions";


                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;

            }
            else if (grade == "3")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Multiplication ";
                butoon_4.Text = "Division";
                button_5.Text = "Order of operations";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "multi";
                checkBox4.Text = "div";
                checkBox5.Text = "order";
                
                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;

            }
            else if (grade == "K")
            {
                button_1.Text = "Addition";
                button_2.Text = "Subtraction";
                button_3.Text = "Money ";
                butoon_4.Text = "Graphing";

                checkBox1.Text = "add";
                checkBox2.Text = "sub";
                checkBox3.Text = "money";
                checkBox4.Text = "graph";

                button_5.Visible = false;
                button_6.Visible = false;
                button_7.Visible = false;
                button_8.Visible = false;
                picture_5.Visible = false;
                picture_6.Visible = false;
                picture_7.Visible = false;
                picture_8.Visible = false;
                butoon_4.Visible = false;
                picture_4.Visible = false;

            }
            if (Screen.PrimaryScreen.Bounds.Width < 1440)
            {
                button_5.Font = new Font("Impact", button_5.Font.Size - 4);
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
                picture_1.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_1.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox1.Checked = true;
                picture_1.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_1.BackColor = Color.FromArgb(255, 255, 128, 0);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
                picture_2.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_2.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox2.Checked = true;
                picture_2.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_2.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
                picture_3.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_3.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox3.Checked = true;
                picture_3.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_3.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
                picture_4.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                butoon_4.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox4.Checked = true;
                picture_4.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                butoon_4.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
                picture_5.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_5.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox5.Checked = true;
                picture_5.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_5.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Checked = false;
                picture_6.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_6.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox6.Checked = true;
                picture_6.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_6.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Checked = false;
                picture_7.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_7.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox7.Checked = true;
                picture_7.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_7.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.Checked = false;
                picture_8.Image = Wildcat_FlashMath.Properties.Resources.check_box_unchecked;
                button_8.BackColor = Color.FromArgb(255, 251, 202, 1);
            }
            else
            {
                checkBox8.Checked = true;
                picture_8.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
                button_8.BackColor = Color.FromArgb(255, 255, 128, 0);

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            picture_1.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_1.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox2.Checked = true;
            picture_2.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_2.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox3.Checked = true;
            picture_3.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_3.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox4.Checked = true;
            picture_4.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            butoon_4.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox5.Checked = true;
            picture_5.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_5.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox6.Checked = true;
            picture_6.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_6.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox7.Checked = true;
            picture_7.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_7.BackColor = Color.FromArgb(255, 255, 128, 0);

            checkBox8.Checked = true;
            picture_8.Image = Wildcat_FlashMath.Properties.Resources.check_box_checked;
            button_8.BackColor = Color.FromArgb(255, 255, 128, 0);

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false &&
                checkBox4.Checked == false &&
                checkBox5.Checked == false &&
                checkBox6.Checked == false &&
                checkBox7.Checked == false &&
                checkBox8.Checked == false)
            {
                MessageBox.Show("No problems selected." + Environment.NewLine + "Please select at least 1 problem.");
            }
            else
            {
                background_info back = new background_info();
                back.lesons = problem_list;
                if (Form1.grade == "1")
                {
                    checkbox_test();
                    _1_problems prob_1 = new _1_problems();
                    _2_problems prob_2 = new _2_problems();
                    _3_problems prob_3 = new _3_problems();
                    _4_problems prob_4 = new _4_problems();
                    _5_problems prob_5 = new _5_problems();
                    k_problems prob_k = new k_problems();

                    

                    prob_1.problem_list = problem_list;
                    prob_1.name = Form1.username;

                    if (problem_list.Count == 0)
                    {
                        return;
                    }

                    prob_1.Show();
                    prob_2.Close();
                    prob_3.Close();
                    prob_4.Close();
                    prob_5.Close();
                    prob_k.Close();
                    this.Close();
                }
                else if (Form1.grade == "2")
                {
                    checkbox_test();
                    _1_problems prob_1 = new _1_problems();
                    _2_problems prob_2 = new _2_problems();
                    _3_problems prob_3 = new _3_problems();
                    _4_problems prob_4 = new _4_problems();
                    _5_problems prob_5 = new _5_problems();
                    k_problems prob_k = new k_problems();

                    prob_2.problem_list = problem_list;
                    if (problem_list.Count == 0)
                    {
                        return;
                    }

                    prob_2.name = Form1.username;
                    prob_1.Close();
                    prob_2.Show();
                    prob_3.Close();
                    prob_4.Close();
                    prob_5.Close();
                    prob_k.Close();

                    this.Close();
                }
                else if (Form1.grade == "3")
                {
                    checkbox_test();
                    _1_problems prob_1 = new _1_problems();
                    _2_problems prob_2 = new _2_problems();
                    _3_problems prob_3 = new _3_problems();
                    _4_problems prob_4 = new _4_problems();
                    _5_problems prob_5 = new _5_problems();
                    k_problems prob_k = new k_problems();

                    prob_3.problem_list = problem_list;

                    if (problem_list.Count == 0)
                    {
                        return;
                    }

                    prob_3.name = Form1.username;
                    prob_1.Close();
                    prob_2.Close();
                    prob_3.Show();
                    prob_4.Close();
                    prob_5.Close();
                    prob_k.Close();

                    this.Close();

                }
                else if (Form1.grade =="4")
                {
                    checkbox_test();
                    _1_problems prob_1 = new _1_problems();
                    _2_problems prob_2 = new _2_problems();
                    _3_problems prob_3 = new _3_problems();
                    _4_problems prob_4 = new _4_problems();
                    _5_problems prob_5 = new _5_problems();
                    k_problems prob_k = new k_problems();

                    prob_4.problem_list = problem_list;

                    if (problem_list.Count == 0)
                    {
                        return;
                    }

                    prob_4.name = Form1.username;
                    prob_1.Close();
                    prob_2.Close();
                    prob_3.Close();
                    prob_4.Show();
                    prob_5.Close();
                    prob_k.Close();

                    this.Close();

                }
                else if (Form1.grade == "5")
                {
                    checkbox_test();
                    _1_problems prob_1 = new _1_problems();
                    _2_problems prob_2 = new _2_problems();
                    _3_problems prob_3 = new _3_problems();
                    _4_problems prob_4 = new _4_problems();
                    _5_problems prob_5 = new _5_problems();
                    k_problems prob_k = new k_problems();

                    prob_5.problem_list = problem_list;

                    if (problem_list.Count == 0)
                    {
                        return;
                    }

                    prob_5.name = Form1.username;
                    prob_1.Close();
                    prob_2.Close();
                    prob_3.Close();
                    prob_4.Close();
                    prob_5.Show();
                    prob_k.Close();

                    this.Close();


                }
                else if (Form1.grade == "K")
                {
                    checkbox_test();
                    _1_problems prob_1 = new _1_problems();
                    _2_problems prob_2 = new _2_problems();
                    _3_problems prob_3 = new _3_problems();
                    _4_problems prob_4 = new _4_problems();
                    _5_problems prob_5 = new _5_problems();
                    k_problems prob_k = new k_problems();

                    prob_k.problem_list = problem_list;

                    if (problem_list.Count == 0)
                    {
                        return;
                    }

                    prob_k.name = Form1.username;
                    prob_1.Close();
                    prob_2.Close();
                    prob_3.Close();
                    prob_4.Close();
                    prob_5.Close();
                    prob_k.Show();
                    this.Close();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_menu mai = new main_menu();
            mai.Show();
            this.Close();        
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
    }
}
